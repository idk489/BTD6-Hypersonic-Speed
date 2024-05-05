using MelonLoader;
using BTD_Mod_Helper;
using TemplateMod;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Towers.Weapons;
using BTD_Mod_Helper.Extensions;

[assembly: MelonInfo(typeof(TemplateMod.TemplateMod), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace TemplateMod;

public class TemplateMod : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<TemplateMod>("TemplateMod loaded!");
    }
    public override void OnNewGameModel(GameModel result)
    {
        foreach(var weapon in result.GetDescendants<WeaponModel>().ToList())
        {
            weapon.rate = 0;
        }
    }
}