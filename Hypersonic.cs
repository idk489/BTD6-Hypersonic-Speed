using MelonLoader;
using BTD_Mod_Helper;
using Hypersonic;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Towers.Weapons;
using BTD_Mod_Helper.Extensions;

[assembly: MelonInfo(typeof(Hypersonic.Hypersonic), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace Hypersonic;

public class Hypersonic : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<Hypersonic>("Hypersonic loaded!");
    }
    public override void OnNewGameModel(GameModel result)
    {
        foreach(var weapon in result.GetDescendants<WeaponModel>().ToList())
        {
            weapon.rate = 0;
        }
    }
}