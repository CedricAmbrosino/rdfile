
using System;
using System.IO;


class Program
{
  static void Main(string[] args)
  {
    string pathFolder = "./Files/";
    string[] filesFolder = Directory.GetFiles(pathFolder);

    if (filesFolder.Length==0)
    {
        Console.WriteLine("Lecture impossible. Aucun fichier présent dans le dossier Files.");
        return;
    }

    Console.WriteLine("Quelle fichier souhaitez-vous lire ?");

    DisplayFilesList(filesFolder,pathFolder);

    int userChoice = AskUserChoice(filesFolder.Length);
    

    DisplayFile(filesFolder, userChoice);
    
  }

    private static void DisplayFilesList(string[] filesFolder,string pathFolder)
    {
        for (int i=0; i<filesFolder.Length;i++)
        {
            string nameFile = filesFolder[i].Substring(pathFolder.Length);
            string nameFileWithoutExtension = nameFile.Remove(nameFile.LastIndexOf("."));
            Console.WriteLine(i+" - " + nameFileWithoutExtension);
        }
    }

  private static int AskUserChoice(int countFiles)
    {
        int  userChoice = -1;

        Console.WriteLine("Entrez le numéro du fichier : ");
        
        while (userChoice<0 || userChoice>=countFiles)
        {
            string? inputUser = Console.ReadLine();
            try
            {
                if(Int32.TryParse(inputUser, out int input))
                {
                    userChoice = input;
                }            
            }
            catch (FormatException)
            {
                Console.WriteLine("Input string is not a sequence of digits.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number cannot fit in an Int32.");
            }

            if(userChoice<0 || userChoice >= countFiles)
            {
                Console.WriteLine("Mauvaise entrée.Entrez le numéro du fichier :  \n ");
            }
            
        }   

        return userChoice;
    }

  private static void DisplayFile(string[] filesFolder, int userChoice)
    {
        Console.WriteLine("\n\n");
        Console.WriteLine("------------");
        Console.WriteLine("\n\n");

        Console.WriteLine(File.ReadAllText(filesFolder[userChoice]));  
    }

}

