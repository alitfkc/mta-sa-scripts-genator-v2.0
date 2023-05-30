using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtasa_script_generator
{
    public class settings
    {
        //Selected create type (veh,ped,object,weapon)
        public static int create_type = 1;

        //on-off acl mode
        public static bool acl_mode = false;
        //acl name
        public static string acl_name ="";

        //on-off data mode
        public static bool data_mode = false;
        //data name 
        public static string data_name = "";

        //txd file location 
        public static string txd_file = "";

        //dff file location
        public static string dff_file = "";

        //id 
        public static int id;

        //save location
        public static string save_location = "";

        //global lists
        public static List<string> type_list = new List<string>();

        public static List<string> meta_type_list = new List<string>();

        public static List<string> data_type_list = new List<string>();

        public static List<string> acl_type_list = new List<string>();

        //Client codes
        public static string client_code_block = "function {1}()\n    local txd = engineLoadTXD ('{2}')\n    engineImportTXD(txd,{0})\n    local dff = engineLoadDFF('{3}',{0})\n    engineReplaceModel(dff,{0})\nend\naddEventHandler('onClientResourceStart',getResourceRootElement(getThisResource()),{1})";


        public static void start()
        {
            // Add type list
            type_list.Add( "Vehicle");
            type_list.Add( "Ped");
            type_list.Add( "Object");
            type_list.Add( "Weapon");
            
            //Add meta type list
            meta_type_list.Add( "<meta>\n  <info author='Meta Scripts' version='1.0' type='script' name='{0}'/>\n  <script src='client.lua' type='client' />\n  <file src='{1}' />\n     <file src='{2}' />\n</meta>");
            meta_type_list.Add( "<meta>\n  <info author='Meta Scripts' version='1.0' type='script' name='{0}'/>\n  <script src='client.lua' type='client' />\n   <script src='server.lua' type='server'/>\n  <file src='{1}' />\n <file src='{2}' />\n</meta>");
            //data type list
                //client
            data_type_list.Add( "addEventHandler('onClientVehicleStartEnter', root, function(player,seat,door)\n	if (player == localPlayer and seat == 0 and getElementModel(source) == {0})then\n        if not getElementData(localPlayer,'{1}') then \n            cancelEvent()\n        end\n	end\nend)");
            data_type_list.Add( "function informPlayerOnModelChange(oldModel, newModel)\n    if  source == localPlayer and newModel == {0} then \n        if not getElementData(localPlayer,'{1}') then \n            setElementModel(localPlayer,oldModel)\n        end\n    end\nend\naddEventHandler('onClientElementModelChange', root, informPlayerOnModelChange) ");
                //server
            data_type_list.Add( "addEventHandler ( 'onPlayerWeaponSwitch', getRootElement (),function ( previousWeaponID, currentWeaponID )\n    if currentWeaponID ==  {0} then\n        if not getElementData(source,'{1}') then \n            takeWeapon(source,'{0}')\n        end\n    end\nend)");


            //acl type list
            acl_type_list.Add( "addEventHandler('onVehicleStartEnter', root, function(player,seat,door)\n	if  seat == 0 and getElementModel(player) == {0}then\n        if not isObjectInACLGroup ('user.'..getAccountName ( getPlayerAccount ( player ) ), aclGetGroup ( '{1}' ) ) then \n            cancelEvent()\n        end\n	end\nend)");
            acl_type_list.Add( "function informPlayerOnModelChange(oldModel, newModel)\n    if  ( getElementType(source) == 'player' ) and newModel == {0} then \n        if not isObjectInACLGroup ('user.'..getAccountName ( getPlayerAccount ( source ) ), aclGetGroup ( '{1}' ) ) then \n            setElementModel(source,oldModel)\n        end\n    end\nend\naddEventHandler('onElementModelChange', root, informPlayerOnModelChange) ");
            acl_type_list.Add( "addEventHandler ( 'onPlayerWeaponSwitch', getRootElement (),function ( previousWeaponID, currentWeaponID )\n    if currentWeaponID ==  {0} then\n        if not isObjectInACLGroup ('user.'..getAccountName ( getPlayerAccount ( source ) ), aclGetGroup ( '{1}' ) ) then  \n            takeWeapon(source,'{0}')\n        end\n    end\nend)");

        }


    }
}
