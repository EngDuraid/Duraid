using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Duraid.Blazor.Services
{
    public abstract class GenericServices<T> : IGenericServices<T>
        where T : class

    {
        readonly HttpClient http;
        private string path;

        public GenericServices(HttpClient http)
        {
            this.http = http;
            CreatePath();
        }

        void CreatePath()
        {
            string name = typeof(T).Name.ToString();// "CategoryDTO";
            string name1 = name.Replace("DTO", "");
            if (name1.EndsWith("y"))
            {
                int lastPosition = (name1.Length) - 1;
                name1 = name1.Remove(lastPosition, 1) + "ies";
            }
            path = name1.ToLower();
        }

        public async Task<IEnumerable<T>> Get() { return await http.GetJsonAsync<IEnumerable<T>>($"api/{path}"); }
        public async Task<T> Get(Guid id) { return await http.GetJsonAsync<T>($"api/{path}/{id}"); }

        public async Task<T> Create(T content)
        {
            try

            {
                await http.PostJsonAsync($"api/{path}", content);
                return content;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<T> Update(Guid id, T content)
        {
            try
            {
                await http.PutJsonAsync<T>($"api/{path}/{id}", content);
                return content;
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }

        public async Task Delete(Guid id)
        {
            HttpResponseMessage x = await http.DeleteAsync($"api/{path}/{id}");
        }
    }
}
