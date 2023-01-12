using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMTools
{
    public class NPCViewModel
    {
        Random random = new Random();
        int teamNr;
        int teamOne;
        int teamTwo;

        public NPCViewModel()
        {

        }
        public void GenerateNPC(ObservableCollection<NPCModel> targetList,int repeat, string name)
        {
            int counter;
            if(name == "Add3Patron")
            {
                counter = 3;
                teamNr = 0;
            }
            else if(name == "Add5Patron")
            {
                counter = 5;
                teamNr = random.Next(0, 2);
                teamOne = random.Next(2, 5);
            }
            else if(name == "Add10Patron")
            {
                counter = 10;
                teamNr = random.Next(1, 3);
                teamOne = random.Next(2, 6);
                teamTwo = random.Next(1, 6);
            }
            else
            {
                counter = repeat;
                if(repeat > 4 && repeat < 10)
                {
                    teamNr = random.Next(0, 2);
                    teamOne = random.Next(2, 5);
                }
                else if(repeat > 10)
                {
                    teamNr = random.Next(1, 3);
                    teamOne = random.Next(2, repeat / 3);
                    teamTwo = random.Next(1, repeat / 3);
                }
            }
            if(teamNr == 1 || teamNr == 2)
            {
                for (int i = 0; i < teamOne; i++)
                {
                    NPCModel npc = new NPCModel();
                    NPCCreator(1, targetList);
                }
                counter -= teamOne;
            }
            if (teamNr == 2)
            {
                teamTwo = random.Next(2, counter);
                for (int i = 0; i < teamTwo; i++)
                {
                    NPCModel npc = new NPCModel();
                    NPCCreator(2, targetList);
                }
                counter -= teamTwo;
            }

            for (int i = 0; i < counter; i++)
            {
                NPCModel npc = new NPCModel();
                NPCCreator(0, targetList);
            }

            
        }
        void NPCCreator(int teamNr, ObservableCollection<NPCModel> targetList)
        {
            NPCModel npcModel = new NPCModel();
            npcModel.Class = npcModel.ClassesList[random.Next(npcModel.ClassesList.Count)];
            npcModel.Race = npcModel.RaceList[random.Next(npcModel.RaceList.Count)];
            int genInt = random.Next(24);
            if (genInt < 11)
            {
                npcModel.Gender = npcModel.GenderList[0];
            }
            else if (genInt > 10 && genInt < 21)
            {
                npcModel.Gender = npcModel.GenderList[1];
            }
            else
            {
                npcModel.Gender = npcModel.GenderList[2];
            }
            npcModel.Adjective = npcModel.AdjectiveList[random.Next(npcModel.AdjectiveList.Count)];
            npcModel.Verb = npcModel.VerbList[random.Next(npcModel.VerbList.Count)];
            npcModel.TeamNr = teamNr;
            targetList.Add(npcModel);
        }

    }
}
