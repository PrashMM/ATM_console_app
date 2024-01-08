﻿using ATM_console_app.Models;
using Newtonsoft.Json;

namespace ATM_console_app.Services
{
    public class JsonFileService
    {
        public void UpdateJson(List<AccountHolder> accountHolderList)
        {
            //string updatedJson = JsonConvert.SerializeObject(accountHolderList);

            //File.WriteAllText(@"C:\json\account.json", updatedJson);
            string updatedJson = JsonConvert.SerializeObject(accountHolderList);
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(folderPath, "account.json");

            File.WriteAllText(filePath, updatedJson);
        }
        

        public void CreateJSONDocument(List<AccountHolder> accountHolderDetailsList)
        {
            string JSONresult = JsonConvert.SerializeObject(accountHolderDetailsList);
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(folderPath, "account.json");

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            File.WriteAllText(filePath, JSONresult);

        }
    }
}