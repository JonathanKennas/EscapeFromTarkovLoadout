using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeFromTarkovLoadout
{
    class ReadMe
    {
        // This Read Me-class contains all the information you need to know when manageing this applicaion, lika adding new items

        // How to add Resources:
        // - Select a picturebox or Form1 (design)
        // - Click on Properties 
        // - Select BackgroundImage and click on the three dots (...)
        // - Mark "Project resource file" and click Import
        // - Choose images and click on "OK"
        // - EDIT: You might need to mark "(none)" in the list for it to not show in the ex. picturebox

        // How to remove Resources: 
        // - Rightclick on the project-file (under the solution) and choose Properties
        // - Click on Resources
        // - Mark image and Remove Resource
        // Link: https://stackoverflow.com/questions/4768759/what-is-the-correct-way-to-remove-resource-images-from-a-vs-project

        // How to publish Windows Forms Application on desktop:
        // - Rightclick on the project-file (under the solution) and choose Properties
        // - Click on Security and select checkbox "Enable ClickOnce security settings
        // - Click on Publish and choose the filepath in "Publishing Folder Location (ftp server or file path)"
        // - Click on "Publish Now"
        // Link: https://www.c-sharpcorner.com/blogs/publishing-windows-form-in-desktop

        // Font for Escape From Tarkov:
        // - Bender Regular
        // - Link to generate text: https://www.1001fonts.com/bender-font.html

        ////When adding (remember to add the ammount to Information.cs aswell):
        // Weapons:
        // - Remember to add image
        // - Control if it's a pistol or not (controling if the weapon is on the sling or holster), control is in Form1.cs
        // Link to all weapons: https://escapefromtarkov.gamepedia.com/Weapons

        // Armor:
        // - Remember to add image
        // Link to all armor: https://escapefromtarkov.gamepedia.com/Armor_vests

        // Headwear:
        // - Remember to add image
        // Link to all headwear: https://escapefromtarkov.gamepedia.com/Headwear

        // Rigs:
        // - Remember to add image
        // - Control if the rig is compatible with armor
        // - Add to controler for armor if it's armored, control is in Armor.cs (GetArmorImage())
        // Link to all rigs: https://escapefromtarkov.gamepedia.com/Chest_rigs#Armored

        // Backpacks:
        // - Remember to add image
        // Link to all backpacks: https://escapefromtarkov.gamepedia.com/Backpacks

        // Maps:
        // - Remember to add image
        // Link to all maps: https://escapefromtarkov.gamepedia.com/Map_of_Tarkov
    }
}
