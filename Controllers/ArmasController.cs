using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RpgMvc.Models;

namespace RpgMvc.Controllers
{
    public class ArmasController : Controller
    {
        public string uriBase = "http://ALima.somee.com/RpgApi/Armas/";

        public async Task<ActionResult> IndexAsync()
        {
            string uriComplementar = "GetAll";

            HttpClient httpClient = new HttpClient();

            string token = HttpContext.Session.GetString("SessionTokenUsuario");
            httpClient.DefaultRequestHeaders.Authorization
                = new AuthenticationHeaderValue("Bearer", token);

            HttpResponseMessage response = await httpClient.GetAsync(uriBase + uriComplementar);

            string serialized = await response.Content.ReadAsStringAsync();

            List<ArmaViewModel> listaArmas = await Task.Run(() => 
                JsonConvert.DeserializeObject<List<ArmaViewModel>>(serialized));

            return View(listaArmas);
        }
        [HttpGet]
        public ActionResult CreateLista()
        {
            return View();
        }
       [HttpGet]
        public async Task<ActionResult> CreateAsync()
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                string token = HttpContext.Session.GetString("SessionTokenUsuario");

                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                string uriBuscaPersonagens = "http://ALima.somee.com/RpgApi/Personagens/GetAll";
                HttpResponseMessage response = await httpClient.GetAsync(uriBuscaPersonagens);


                string serialized = await response.Content.ReadAsStringAsync();

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    List<PersonagemViewModel> listaPersonagens = await Task.Run(() =>
                        JsonConvert.DeserializeObject<List<PersonagemViewModel>>(serialized));
                    ViewBag.PersonagemId = listaPersonagens;

                }
                else
                    throw new System.Exception(serialized);

                return View("Create");
            }
            catch (System.Exception ex)
            {
                TempData["MensagemErro"] = ex.Message;
                return RedirectToAction("Index");
            }
        }

             [HttpPost]
        public async Task<ActionResult> CreateAsync(ArmaViewModel arma)
        {
            try
            {
                 HttpClient httpClient = new HttpClient();
                 string token = HttpContext.Session.GetString("SessionTokenUsuario");
                 httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue ("Bearer", token);
                 var content = new StringContent (JsonConvert.SerializeObject(arma));
                 content.Headers.ContentType = new MediaTypeHeaderValue ("application/json");
                 HttpResponseMessage response = await httpClient.PostAsync(uriBase, content);                
                string serialized = await response.Content.ReadAsStringAsync();
                 if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    TempData["Mensagem"] = string.Format("Arma {0}, Id {1} salva com sucesso!", arma.Nome, serialized);
                    return RedirectToAction("Index");
                }
                else
                    throw new System.Exception(serialized);
            }
            catch (System.Exception ex)
            {
                TempData["MensagemErro"] = ex.Message;
                return RedirectToAction("Index");

            }
        }

        [HttpGet]
        public async Task<ActionResult> DetailsAsync(int? id)
        {
            HttpClient httpClient = new HttpClient();

            string token = HttpContext.Session.GetString("SessionTokenUsuario");
            httpClient.DefaultRequestHeaders.Authorization
                = new AuthenticationHeaderValue("Bearer", token);

            HttpResponseMessage response = await httpClient.GetAsync(uriBase + id.ToString());
            string serialized = await response.Content.ReadAsStringAsync();

            ArmaViewModel arma = await Task.Run(() =>
                JsonConvert.DeserializeObject<ArmaViewModel>(serialized));
            
            return View(arma);
        }

        [HttpGet]
        public async Task<ActionResult> EditAsync(int? id)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                string token = HttpContext.Session.GetString("SessionTokenUsuario");

                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                HttpResponseMessage response = await httpClient.GetAsync(uriBase + id.ToString());

                ArmaViewModel a = new ArmaViewModel();

                string serialized = await response.Content.ReadAsStringAsync();

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    a = await Task.Run(() =>
                    JsonConvert.DeserializeObject<ArmaViewModel>(serialized));
                    
                }
                else
                {
                    throw new System.EntryPointNotFoundException(serialized);
                }
                
                string uriBuscaPersonagens = "http://ALima.somee.com/RpgApi/Personagens/GetAll";
                response = await httpClient.GetAsync(uriBuscaPersonagens);
                serialized = await response.Content.ReadAsStringAsync();

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    List<PersonagemViewModel> listaPersonagens = await Task.Run(() =>
                        JsonConvert.DeserializeObject<List<PersonagemViewModel>>(serialized));
                    ViewBag.PersonagemId = listaPersonagens;
                }
                else
                    throw new System.Exception(serialized);

                return View(a);

            }
            catch (System.Exception ex)
            {
                TempData["MensagemErro"] = ex.Message;
                return RedirectToAction("Index");
            }
        
        }

        [HttpPost]
        public async Task<ActionResult> EditAsync(ArmaViewModel arma)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                string token = HttpContext.Session.GetString("SessionTokenUsuario");

                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var content = new StringContent(JsonConvert.SerializeObject(arma));
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                HttpResponseMessage response = await httpClient.PutAsync(uriBase, content);
                string serialized = await response.Content.ReadAsStringAsync();

                if(response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    TempData["Mensagem"] =
                        string.Format("Arma {0} atualizada com sucesso!", arma.Nome);

                    return RedirectToAction("Index", "Armas");
                }
                else
                    throw new System.Exception(serialized);

            }
            catch (System.Exception ex)
            {
                
                TempData["MensagemErro"] = ex.Message;
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                string token = HttpContext.Session.GetString("SessionTokenUsuario");

                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                HttpResponseMessage response = await httpClient.DeleteAsync(uriBase + id.ToString());

                string serialized = await response.Content.ReadAsStringAsync();

                if(response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    TempData["Mensagem"] = string.Format("Arma Id {0} removida com sucesso!", id);
                    return RedirectToAction("Index");
                }
                else
                    throw new System.Exception(serialized);
            }
            catch (System.Exception ex)
            {
                
                TempData["MensagemErro"] = ex.Message;
                return RedirectToAction("Index");
            }
        }

    }
}