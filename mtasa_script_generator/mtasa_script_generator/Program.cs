using System.IO;
using System.Xml;
using System.Collections;

namespace mtasa_script_generator
{ 
     static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            settings.start();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }

        public static string createXmlText(string folderName)
        {

            string xmlT = "";
            int count = 0;
            if (settings.acl_mode)
            {
                count = 1;
            }
            else if (settings.data_mode && settings.create_type == 4)
            {
                count = 1;
            }
            else
            {
                count = 0;
            }


            xmlT = string.Format(settings.meta_type_list[count] ,folderName,settings.id.ToString()+".txd",settings.id.ToString() + ".dff");
            return xmlT;
        }

        //copied and pasted file
        public static void CopyFileToFolder(string sourceFilePath, string destinationFolderPath,string new_file_name)
        {
            // Kaynak dosyanýn adýný ve hedef yolun tam yolunu birleþtirin
            string destinationFilePath = Path.Combine(destinationFolderPath, new_file_name);

            // Dosyayý kopyalayýn
            File.Copy(sourceFilePath, destinationFilePath);
        }
        public static void genarate()
        {

            string folder_name = "";
            string way = "";
            string xmlWay = "";
            

            folder_name = settings.type_list[settings.create_type-1] ;

            if (settings.save_location != "")
            {
                way = Path.Combine(@settings.save_location, folder_name);
                xmlWay = @settings.save_location + "/" + way + "/meta.xml";
            }
            else
            {
                string desktop_directory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                // Klasörün tam dizinini oluþtur
                way = Path.Combine(@desktop_directory, folder_name + settings.id.ToString());
                xmlWay = @desktop_directory + "/" + way + "/meta.xml";

            }
            //Create Folder
            Directory.CreateDirectory(way);

            //create meta
            string xmlFilePath = Path.Combine(way,"meta.xml");
            string xmlText = createXmlText(folder_name);
            File.WriteAllText(xmlFilePath, xmlText);

            //coppied and paste from txd and dff
            CopyFileToFolder(settings.txd_file,way,settings.id.ToString()+".txd");
            CopyFileToFolder(settings.dff_file, way,settings.id.ToString()+".dff");

            //Create Client.lua File
            string client_code = string.Format(settings.client_code_block, settings.id, folder_name + settings.id.ToString(), settings.id.ToString() + ".txd", settings.id +".dff");
            
            if (settings.data_mode && settings.create_type <=2)
            {
                client_code += "\n\n\n" + string.Format(settings.data_type_list[settings.create_type - 1], settings.id, settings.data_name);
            }
            string clientLuaFile = Path.Combine(way, "client.lua");
            File.WriteAllText(clientLuaFile, client_code);

            //Create Server.lua file
            string server_code = "";
            if (settings.acl_mode && settings.create_type !=3) {
                int count = 0;
                if (settings.create_type ==4) {
                    count = 2;
                }
                else
                {
                    count = settings.create_type - 1;
                }
                server_code += string.Format(settings.acl_type_list[count],settings.id,settings.acl_name);
            }
            if  (settings.data_mode && settings.create_type ==4) {

                server_code += "\n\n\n" + string.Format(settings.data_type_list[2], settings.id, settings.data_name);
            }
            string serverLuaFile = Path.Combine(way, "server.lua");
            File.WriteAllText(serverLuaFile, server_code);
        }
    }

}