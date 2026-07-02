# ACNServerMod
Template mod that makes the All City Network always connect to your server

This repo is a template of a mod that makes All City Network skip trying to connect to the server address in the All City Network/BombRushMP config file, and instead always auto connect to the server address you put in this mod. 

# How To Use:

- Edit the server address in Patches/ServerAddressPatch.cs to match your server address/IP

- Edit the namespace in "Plugin.cs" and Patches/ServerAddressPatch.cs to the name of your mod

- Edit the name of the mod from "ACNServerMod" in ACNServerMod.csproj to what you want the mod to be named in the AssemblyName and AssemblyTitle slots

- Rename the ACNServerMod.csproj file to your mod, but keep the file extension, like YourModNameHere.csproj

- Edit the description for the mod in ACNServerMod.csproj to match your mod

- Build the mod using dotnet/.NET

- Once built, your mod will appear in the bin\Release\net472 folder

- Delete the pdb file

- Now you can take your .dll file in bin\Release\net472 , and either hand it to your friends, or upload it to thunderstore for others to easily download.
