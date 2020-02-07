using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Matchvs;
using LitJson;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace UnknownRealm
{

    public class UnknownRealm : MonoBehaviour
    {
        static string APP_KEY = "a8dada5fe7614720844f66c08259da46#M";
        static uint GAME_ID = 218228;
        static uint VERISON = 0;
        private Config config;
        private static UnknownRealm INSTANCE;
        private static string CONFIG_PATH;
        MatchvsEngine engine = MatchvsEngine.getInstance();

        public static  UnknownRealm  getInstance() {
            return INSTANCE;
        }
        public void loadConfig() {
          

            if (File.Exists(CONFIG_PATH))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Open(CONFIG_PATH, FileMode.Open);
                config = (Config)bf.Deserialize(file);
                Debug.Log("Config Loaded With File "+file.Name);
                file.Close();
            }
            else {
                config = new Config();
                Debug.Log("Config Loaded WithOut File");
 
            }

        }
        public void saveConfig()
        {
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(CONFIG_PATH))
            {
                File.Delete(CONFIG_PATH);
            }
            FileStream file = File.Create(CONFIG_PATH);
            bf.Serialize(file, getConfig());
            file.Close();
        }
        public Config getConfig() {
            return this.config;
        }

        private void Awake()
        {
            CONFIG_PATH = Application.dataPath + @"/config";
            INSTANCE = this;
            loadConfig();
            DontDestroyOnLoad(this);
            Debug.Log("Current Config Patch" +CONFIG_PATH);
        }
        private void Start()
        {
            initEngine();
            Debug.Log("MatchVs Engine Loaded");

        }
        private void initEngine()
        {
            engine.init(GetComponent<UnityContext>(), GAME_ID, APP_KEY);
           
        }
        private UnknownRealm() { }

    }

}