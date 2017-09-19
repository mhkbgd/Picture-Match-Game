using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using System.Text;


public class MenuBehavior : MonoBehaviour {
    public Dropdown patientDropdown;

    public InputField date;
    public string currentPatient;
    public void mainMenuTrigger(int i) {
        switch (i) {
            default:
            case (0):
                selection();
                Savecsv();
                break;

            case (1):
                UnityEngine.Application.Quit();
                break;

        }
       
    }
    
    

    public void selection()
    {
        switch (patientDropdown.value)
        {
            default:
                break;
            case 0:
                currentPatient = "Mahmud";
                SceneManager.LoadScene("level1");
                break;
            case 1:
                SceneManager.LoadScene("Shahin");
                break;
        }
    }
    void Savecsv()
    {
        string filePath = @"/"+currentPatient+"-"+date.text+ ".csv";
        string delimiter = ",";

        string[][] output = new string[][]{
             new string[]{"Col 1 Row 1", "Col 2 Row 1", "Col 3 Row 1"},
             new string[]{"Col1 Row 2", "Col2 Row 2", "Col3 Row 2"}
         };
        int length = output.GetLength(0);
        StringBuilder sb = new StringBuilder();
        for (int index = 0; index < length; index++)
            sb.AppendLine(string.Join(delimiter, output[index]));

        File.WriteAllText(filePath, sb.ToString());
    }
}
