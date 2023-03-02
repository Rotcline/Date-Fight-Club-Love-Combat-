using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class main_interface : MonoBehaviour
{
    public TMP_InputField inputPrompt;
    private Queue listOfMovements = new Queue();
    
    static async Task Function()
    {
        using var httpClient = new HttpClient();

        var url = "https://randomuser.me/api/";

        var response = await httpClient.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            var json_complete = JsonConvert.DeserializeObject<MessageResponse>(content);
            Debug.Log($"");
        }
    }

    public void SubmitText()
    {
        Debug.Log(inputPrompt.text);
        inputPrompt.text = "";
        inputPrompt.placeholder.gameObject.SetActive(false);
        Function();
    }

    public class MessageResponse
    {
        public string emotion { get; set; }
        public string message { get; set; }
        
    }

    public class Test1
    {
        public int counter { get; set; }
        public List<String> some_shit { get; set; }
    }
}
