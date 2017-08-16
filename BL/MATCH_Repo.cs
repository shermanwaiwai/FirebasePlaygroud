using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FirebasePlayground.Model;

namespace FirebasePlayground.BL
{
    public class MATCH_Repo : baseRepo<MATCH>
    {
        private FirebaseClient client { get; set; }
        public MATCH_Repo(FirebaseClient _client)
        {
            if (_client == null)
            {
                client = new Firebase().client();
            }
            this.client = _client;
        }
        public Task create(MATCH obj)
        {
            throw new NotImplementedException();
        }

        public async Task createByChild(string child, MATCH obj)
        {
            var result = await this.client
               .Child(child)
               .PostAsync(JsonConvert.SerializeObject(obj));
        }

        public async Task deleteByKey(string key)
        {
            await this.client
              .Child(key)
              .DeleteAsync();
        }

        public Task<IEnumerable<MATCH>> getAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MATCH>> getAllByChild(string child)
        {
            throw new NotImplementedException();
        }

        public Task<MATCH> getByKey(string key)
        {
            throw new NotImplementedException();
        }

        public Task update(MATCH obj)
        {
            throw new NotImplementedException();
        }
        public async Task update(string child, MATCH obj)
        {
            await this.client
                .Child(child)
                .PutAsync(JsonConvert.SerializeObject(obj));
        }
    }
}
