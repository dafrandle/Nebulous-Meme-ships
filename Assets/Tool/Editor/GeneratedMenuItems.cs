﻿// This class is Auto-Generated
using UnityEngine;
using UnityEditor;
using System.IO;

public class Holder : MonoBehaviour
{
    public ScriptableObject a;
}
public class GeneratedMenuItems : MonoBehaviour {
    static AssetBundle stock; 
    
    [MenuItem("Load Asset/Stock/F1/Weapons/Mk65 Cannon.prefab")]
    private static void MenuItem0() {
        Debug.Log("Selected item: Mk65 Cannon");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Mk65 Cannon"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Munitions/Missile Components/Fast Startup Module.asset")]
    private static void MenuItem1() {
        Debug.Log("Selected item: Fast Startup Module");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Fast Startup Module holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Fast Startup Module"); 
        
    }

    [MenuItem("Load Asset/Stock/Common/Munitions/Missile Components/Decoy Launcher.asset")]
    private static void MenuItem2() {
        Debug.Log("Selected item: Decoy Launcher");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Decoy Launcher holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Decoy Launcher"); 
        
    }

    [MenuItem("Load Asset/Stock/F2/Munitions/CM-4D1 Decoy Container (Clipper).prefab")]
    private static void MenuItem3() {
        Debug.Log("Selected item: CM-4D1 Decoy Container (Clipper)");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("CM-4D1 Decoy Container (Clipper)"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Components/ES32 'Scryer' Missile ID System.prefab")]
    private static void MenuItem4() {
        Debug.Log("Selected item: ES32 'Scryer' Missile ID System");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("ES32 'Scryer' Missile ID System"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Drives/FM580 'Raider' Drive.prefab")]
    private static void MenuItem5() {
        Debug.Log("Selected item: FM580 'Raider' Drive");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("FM580 'Raider' Drive"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Energy Regulator.prefab")]
    private static void MenuItem6() {
        Debug.Log("Selected item: Energy Regulator");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Energy Regulator"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Munitions/250mm HE-RPF Shell.asset")]
    private static void MenuItem7() {
        Debug.Log("Selected item: 250mm HE-RPF Shell");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("250mm HE-RPF Shell holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("250mm HE-RPF Shell"); 
        
    }

    [MenuItem("Load Asset/Stock/Debuffs/FC Waveguide Bent.asset")]
    private static void MenuItem8() {
        Debug.Log("Selected item: FC Waveguide Bent");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("FC Waveguide Bent holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("FC Waveguide Bent"); 
        
    }

    [MenuItem("Load Asset/Stock/F1/Weapons/VLS-1-46 Launcher.prefab")]
    private static void MenuItem9() {
        Debug.Log("Selected item: VLS-1-46 Launcher");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("VLS-1-46 Launcher"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Drives/BW800-R Drive.prefab")]
    private static void MenuItem10() {
        Debug.Log("Selected item: BW800-R Drive");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("BW800-R Drive"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Drives/BW1500-R Drive.prefab")]
    private static void MenuItem11() {
        Debug.Log("Selected item: BW1500-R Drive");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("BW1500-R Drive"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Drives/FM230 'Whiplash' Drive.prefab")]
    private static void MenuItem12() {
        Debug.Log("Selected item: FM230 'Whiplash' Drive");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("FM230 'Whiplash' Drive"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Hulls/Keystone Destroyer.prefab")]
    private static void MenuItem13() {
        Debug.Log("Selected item: Keystone Destroyer");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Keystone Destroyer"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Hulls/Vauxhall Light Cruiser.prefab")]
    private static void MenuItem14() {
        Debug.Log("Selected item: Vauxhall Light Cruiser");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Vauxhall Light Cruiser"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Small Energy Regulator.prefab")]
    private static void MenuItem15() {
        Debug.Log("Selected item: Small Energy Regulator");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Small Energy Regulator"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Munitions/15mm Sandshot.asset")]
    private static void MenuItem16() {
        Debug.Log("Selected item: 15mm Sandshot");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("15mm Sandshot holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("15mm Sandshot"); 
        
    }

    [MenuItem("Load Asset/Stock/F2/Weapons/R400 'Bloodhound' LRT Radar.prefab")]
    private static void MenuItem17() {
        Debug.Log("Selected item: R400 'Bloodhound' LRT Radar");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("R400 'Bloodhound' LRT Radar"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Weapons/J17 Jammer.prefab")]
    private static void MenuItem18() {
        Debug.Log("Selected item: J17 Jammer");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("J17 Jammer"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Weapons/T20 Cannon.prefab")]
    private static void MenuItem19() {
        Debug.Log("Selected item: T20 Cannon");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("T20 Cannon"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Drives/FM200 Drive.prefab")]
    private static void MenuItem20() {
        Debug.Log("Selected item: FM200 Drive");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("FM200 Drive"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Munitions/SGT-3/SGT-3 Body.prefab")]
    private static void MenuItem21() {
        Debug.Log("Selected item: SGT-3 Body");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("SGT-3 Body"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Drives/FM500 Drive.prefab")]
    private static void MenuItem22() {
        Debug.Log("Selected item: FM500 Drive");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("FM500 Drive"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Weapons/CLS-3 Launcher.prefab")]
    private static void MenuItem23() {
        Debug.Log("Selected item: CLS-3 Launcher");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("CLS-3 Launcher"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Components/Strike Planning Center.prefab")]
    private static void MenuItem24() {
        Debug.Log("Selected item: Strike Planning Center");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Strike Planning Center"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Munitions/Missile Components/HE Kinetic Penetrator.asset")]
    private static void MenuItem25() {
        Debug.Log("Selected item: HE Kinetic Penetrator");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("HE Kinetic Penetrator holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("HE Kinetic Penetrator"); 
        
    }

    [MenuItem("Load Asset/Stock/F2/Munitions/M-30 'Mattock' Mine.prefab")]
    private static void MenuItem26() {
        Debug.Log("Selected item: M-30 'Mattock' Mine");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("M-30 'Mattock' Mine"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Munitions/Missile Components/Cluster Decoy Launcher.asset")]
    private static void MenuItem27() {
        Debug.Log("Selected item: Cluster Decoy Launcher");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Cluster Decoy Launcher holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Cluster Decoy Launcher"); 
        
    }

    [MenuItem("Load Asset/Stock/F1/Hulls/Sprinter Corvette.prefab")]
    private static void MenuItem28() {
        Debug.Log("Selected item: Sprinter Corvette");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Sprinter Corvette"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Weapons/P20 'Bastion' PDT.prefab")]
    private static void MenuItem29() {
        Debug.Log("Selected item: P20 'Bastion' PDT");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("P20 'Bastion' PDT"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Components/FR3300 Micro Reactor.prefab")]
    private static void MenuItem30() {
        Debug.Log("Selected item: FR3300 Micro Reactor");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("FR3300 Micro Reactor"));
        
    }

    [MenuItem("Load Asset/Stock/Debuffs/Reactor Explosion Event.asset")]
    private static void MenuItem31() {
        Debug.Log("Selected item: Reactor Explosion Event");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Reactor Explosion Event holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Reactor Explosion Event"); 
        
    }

    [MenuItem("Load Asset/Stock/Munitions/SGM-210 Squall.prefab")]
    private static void MenuItem32() {
        Debug.Log("Selected item: SGM-210 Squall");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("SGM-210 Squall"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Reinforced DC Locker.prefab")]
    private static void MenuItem33() {
        Debug.Log("Selected item: Reinforced DC Locker");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Reinforced DC Locker"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Drives/FM540 'Dragonfly' Drive.prefab")]
    private static void MenuItem34() {
        Debug.Log("Selected item: FM540 'Dragonfly' Drive");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("FM540 'Dragonfly' Drive"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Weapons/RL36 Launcher.prefab")]
    private static void MenuItem35() {
        Debug.Log("Selected item: RL36 Launcher");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("RL36 Launcher"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Components/Ithaca Bridgemaster.prefab")]
    private static void MenuItem36() {
        Debug.Log("Selected item: Ithaca Bridgemaster");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Ithaca Bridgemaster"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Magazine Sprinklers.prefab")]
    private static void MenuItem37() {
        Debug.Log("Selected item: Magazine Sprinklers");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Magazine Sprinklers"));
        
    }

    [MenuItem("Load Asset/Stock/Scenarios/Center Flag.asset")]
    private static void MenuItem38() {
        Debug.Log("Selected item: Center Flag");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Center Flag holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Center Flag"); 
        
    }

    [MenuItem("Load Asset/Stock/F1/Drives/FM530 'Whiplash' Drive.prefab")]
    private static void MenuItem39() {
        Debug.Log("Selected item: FM530 'Whiplash' Drive");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("FM530 'Whiplash' Drive"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/CR10 Antenna.prefab")]
    private static void MenuItem40() {
        Debug.Log("Selected item: CR10 Antenna");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("CR10 Antenna"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Munitions/CM-4M Mine Container.prefab")]
    private static void MenuItem41() {
        Debug.Log("Selected item: CM-4M Mine Container");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("CM-4M Mine Container"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Drives/FM30X 'Prowler' Drive.prefab")]
    private static void MenuItem42() {
        Debug.Log("Selected item: FM30X 'Prowler' Drive");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("FM30X 'Prowler' Drive"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Munitions/EA99 Active Decoy.prefab")]
    private static void MenuItem43() {
        Debug.Log("Selected item: EA99 Active Decoy");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("EA99 Active Decoy"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Faction Protectorate.asset")]
    private static void MenuItem44() {
        Debug.Log("Selected item: Faction Protectorate");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Faction Protectorate holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Faction Protectorate"); 
        
    }

    [MenuItem("Load Asset/Stock/F2/Munitions/CM-4R Rocket Container.prefab")]
    private static void MenuItem45() {
        Debug.Log("Selected item: CM-4R Rocket Container");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("CM-4R Rocket Container"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Munitions/450mm AP Shell.asset")]
    private static void MenuItem46() {
        Debug.Log("Selected item: 450mm AP Shell");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("450mm AP Shell holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("450mm AP Shell"); 
        
    }

    [MenuItem("Load Asset/Stock/Maps/Caltrop.prefab")]
    private static void MenuItem47() {
        Debug.Log("Selected item: Caltrop");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Caltrop"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Components/Boosted Reactor.prefab")]
    private static void MenuItem48() {
        Debug.Log("Selected item: Boosted Reactor");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Boosted Reactor"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Munitions/Missile Components/Blast Fragmentation.asset")]
    private static void MenuItem49() {
        Debug.Log("Selected item: Blast Fragmentation");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Blast Fragmentation holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Blast Fragmentation"); 
        
    }

    [MenuItem("Load Asset/Stock/F1/Munitions/300mm AP Rail Sabot.asset")]
    private static void MenuItem50() {
        Debug.Log("Selected item: 300mm AP Rail Sabot");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("300mm AP Rail Sabot holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("300mm AP Rail Sabot"); 
        
    }

    [MenuItem("Load Asset/Stock/F1/Weapons/Mk82 Railgun.prefab")]
    private static void MenuItem51() {
        Debug.Log("Selected item: Mk82 Railgun");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Mk82 Railgun"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Weapons/Mk20 'Defender' PDT.prefab")]
    private static void MenuItem52() {
        Debug.Log("Selected item: Mk20 'Defender' PDT");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Mk20 'Defender' PDT"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Track Correlator.prefab")]
    private static void MenuItem53() {
        Debug.Log("Selected item: Track Correlator");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Track Correlator"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Munitions/Missile Components/Submunition Decoy.prefab")]
    private static void MenuItem54() {
        Debug.Log("Selected item: Submunition Decoy");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Submunition Decoy"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Weapons/Mk29 'Stonewall' PDT.prefab")]
    private static void MenuItem55() {
        Debug.Log("Selected item: Mk29 'Stonewall' PDT");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Mk29 'Stonewall' PDT"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Missile Programming Bus.prefab")]
    private static void MenuItem56() {
        Debug.Log("Selected item: Missile Programming Bus");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Missile Programming Bus"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Weapons/Mk610 Beam Turret.prefab")]
    private static void MenuItem57() {
        Debug.Log("Selected item: Mk610 Beam Turret");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Mk610 Beam Turret"));
        
    }

    [MenuItem("Load Asset/Stock/Debuffs/Container Bank Cookoff.asset")]
    private static void MenuItem58() {
        Debug.Log("Selected item: Container Bank Cookoff");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Container Bank Cookoff holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Container Bank Cookoff"); 
        
    }

    [MenuItem("Load Asset/Stock/Maps/Asteroid Thicket.prefab")]
    private static void MenuItem59() {
        Debug.Log("Selected item: Asteroid Thicket");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Asteroid Thicket"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Hulls/Bulk Clipper.prefab")]
    private static void MenuItem60() {
        Debug.Log("Selected item: Bulk Clipper");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Bulk Clipper"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Munitions/250mm HE Shell.asset")]
    private static void MenuItem61() {
        Debug.Log("Selected item: 250mm HE Shell");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("250mm HE Shell holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("250mm HE Shell"); 
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Redundant Reactor Failsafes.prefab")]
    private static void MenuItem62() {
        Debug.Log("Selected item: Redundant Reactor Failsafes");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Redundant Reactor Failsafes"));
        
    }

    [MenuItem("Load Asset/Stock/Debuffs/Atmosphere Leak.asset")]
    private static void MenuItem63() {
        Debug.Log("Selected item: Atmosphere Leak");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Atmosphere Leak holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Atmosphere Leak"); 
        
    }

    [MenuItem("Load Asset/Stock/Common/Munitions/Missile Components/Fixed Active Radar Seeker.asset")]
    private static void MenuItem64() {
        Debug.Log("Selected item: Fixed Active Radar Seeker");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Fixed Active Radar Seeker holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Fixed Active Radar Seeker"); 
        
    }

    [MenuItem("Load Asset/Stock/F1/Munitions/EA12 Chaff Decoy.prefab")]
    private static void MenuItem65() {
        Debug.Log("Selected item: EA12 Chaff Decoy");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("EA12 Chaff Decoy"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Plant Control Center.prefab")]
    private static void MenuItem66() {
        Debug.Log("Selected item: Plant Control Center");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Plant Control Center"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Weapons/TE45 Mass Driver.prefab")]
    private static void MenuItem67() {
        Debug.Log("Selected item: TE45 Mass Driver");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("TE45 Mass Driver"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Weapons/P60 'Grazer' PDT.prefab")]
    private static void MenuItem68() {
        Debug.Log("Selected item: P60 'Grazer' PDT");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("P60 'Grazer' PDT"));
        
    }

    [MenuItem("Load Asset/Stock/Scenarios/Station Capture.asset")]
    private static void MenuItem69() {
        Debug.Log("Selected item: Station Capture");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Station Capture holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Station Capture"); 
        
    }

    [MenuItem("Load Asset/Stock/F2/Weapons/P11 'Pavise' PDT.prefab")]
    private static void MenuItem70() {
        Debug.Log("Selected item: P11 'Pavise' PDT");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("P11 'Pavise' PDT"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Munitions/500mm Fracturing Block.asset")]
    private static void MenuItem71() {
        Debug.Log("Selected item: 500mm Fracturing Block");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("500mm Fracturing Block holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("500mm Fracturing Block"); 
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Intelligence Center.prefab")]
    private static void MenuItem72() {
        Debug.Log("Selected item: Intelligence Center");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Intelligence Center"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Weapons/C81 Plasma Cannon.prefab")]
    private static void MenuItem73() {
        Debug.Log("Selected item: C81 Plasma Cannon");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("C81 Plasma Cannon"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Munitions/SGM-H-3/SGM-H-3 Body.prefab")]
    private static void MenuItem74() {
        Debug.Log("Selected item: SGM-H-3 Body");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("SGM-H-3 Body"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Hulls/Shuttle Clipper.prefab")]
    private static void MenuItem75() {
        Debug.Log("Selected item: Shuttle Clipper");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Shuttle Clipper"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Weapons/Mk90 'Aurora' PDT.prefab")]
    private static void MenuItem76() {
        Debug.Log("Selected item: Mk90 'Aurora' PDT");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Mk90 'Aurora' PDT"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Hulls/Tug Clipper.prefab")]
    private static void MenuItem77() {
        Debug.Log("Selected item: Tug Clipper");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Tug Clipper"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Weapons/Mk61 Cannon.prefab")]
    private static void MenuItem78() {
        Debug.Log("Selected item: Mk61 Cannon");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Mk61 Cannon"));
        
    }

    [MenuItem("Load Asset/Stock/Voices/Meccanismo Voice.asset")]
    private static void MenuItem79() {
        Debug.Log("Selected item: Meccanismo Voice");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Meccanismo Voice holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Meccanismo Voice"); 
        
    }

    [MenuItem("Load Asset/Stock/Debuffs/Ammunition Loader Jammed.asset")]
    private static void MenuItem80() {
        Debug.Log("Selected item: Ammunition Loader Jammed");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Ammunition Loader Jammed holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Ammunition Loader Jammed"); 
        
    }

    [MenuItem("Load Asset/Stock/F1/Drives/FM500R Drive.prefab")]
    private static void MenuItem81() {
        Debug.Log("Selected item: FM500R Drive");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("FM500R Drive"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Munitions/Missile Components/Cold Gas Bottle.asset")]
    private static void MenuItem82() {
        Debug.Log("Selected item: Cold Gas Bottle");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Cold Gas Bottle holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Cold Gas Bottle"); 
        
    }

    [MenuItem("Load Asset/Stock/Debuffs/Turret Bearing Surface Bent.asset")]
    private static void MenuItem83() {
        Debug.Log("Selected item: Turret Bearing Surface Bent");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Turret Bearing Surface Bent holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Turret Bearing Surface Bent"); 
        
    }

    [MenuItem("Load Asset/Stock/F1/Components/FR4800 Reactor.prefab")]
    private static void MenuItem84() {
        Debug.Log("Selected item: FR4800 Reactor");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("FR4800 Reactor"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Weapons/RF101 'Bullseye' Radar.prefab")]
    private static void MenuItem85() {
        Debug.Log("Selected item: RF101 'Bullseye' Radar");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("RF101 'Bullseye' Radar"));
        
    }

    [MenuItem("Load Asset/Stock/Voices/Delly Voice.asset")]
    private static void MenuItem86() {
        Debug.Log("Selected item: Delly Voice");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Delly Voice holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Delly Voice"); 
        
    }

    [MenuItem("Load Asset/Stock/F2/Hulls/Bulker Line Ship.prefab")]
    private static void MenuItem87() {
        Debug.Log("Selected item: Bulker Line Ship");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Bulker Line Ship"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Munitions/M-50 'Auger' Sprint Mine.prefab")]
    private static void MenuItem88() {
        Debug.Log("Selected item: M-50 'Auger' Sprint Mine");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("M-50 'Auger' Sprint Mine"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/SH12-25 REDACTED.prefab")]
    private static void MenuItem89() {
        Debug.Log("Selected item: SH12-25 REDACTED");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("SH12-25 REDACTED"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Munitions/Missile Components/Wake-Homing Seeker.asset")]
    private static void MenuItem90() {
        Debug.Log("Selected item: Wake-Homing Seeker");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Wake-Homing Seeker holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Wake-Homing Seeker"); 
        
    }

    [MenuItem("Load Asset/Stock/F1/Hulls/Axford Heavy Cruiser.prefab")]
    private static void MenuItem91() {
        Debug.Log("Selected item: Axford Heavy Cruiser");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Axford Heavy Cruiser"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Munitions/Missile Components/Radar Absorbent Coating.asset")]
    private static void MenuItem92() {
        Debug.Log("Selected item: Radar Absorbent Coating");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Radar Absorbent Coating holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Radar Absorbent Coating"); 
        
    }

    [MenuItem("Load Asset/Stock/F1/Munitions/450mm HE Shell.asset")]
    private static void MenuItem93() {
        Debug.Log("Selected item: 450mm HE Shell");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("450mm HE Shell holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("450mm HE Shell"); 
        
    }

    [MenuItem("Load Asset/Stock/F1/Weapons/Mk81 Railgun.prefab")]
    private static void MenuItem94() {
        Debug.Log("Selected item: Mk81 Railgun");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Mk81 Railgun"));
        
    }

    [MenuItem("Load Asset/Stock/Debuffs/Fire.asset")]
    private static void MenuItem95() {
        Debug.Log("Selected item: Fire");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Fire holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Fire"); 
        
    }

    [MenuItem("Load Asset/Stock/F2/Hulls/Ocello Cruiser.prefab")]
    private static void MenuItem96() {
        Debug.Log("Selected item: Ocello Cruiser");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Ocello Cruiser"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Drives/FM240 'Dragonfly' Drive.prefab")]
    private static void MenuItem97() {
        Debug.Log("Selected item: FM240 'Dragonfly' Drive");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("FM240 'Dragonfly' Drive"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Hulls/Raines Frigate.prefab")]
    private static void MenuItem98() {
        Debug.Log("Selected item: Raines Frigate");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Raines Frigate"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Munitions/Missile Components/Blast Fragmentation EL.asset")]
    private static void MenuItem99() {
        Debug.Log("Selected item: Blast Fragmentation EL");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Blast Fragmentation EL holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Blast Fragmentation EL"); 
        
    }

    [MenuItem("Load Asset/Stock/Munitions/Sensor Buoy.prefab")]
    private static void MenuItem100() {
        Debug.Log("Selected item: Sensor Buoy");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Sensor Buoy"));
        
    }

    [MenuItem("Load Asset/Stock/Debuffs/Fuel Line Explosion Event.asset")]
    private static void MenuItem101() {
        Debug.Log("Selected item: Fuel Line Explosion Event");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Fuel Line Explosion Event holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Fuel Line Explosion Event"); 
        
    }

    [MenuItem("Load Asset/Stock/Voices/Griff Voice.asset")]
    private static void MenuItem102() {
        Debug.Log("Selected item: Griff Voice");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Griff Voice holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Griff Voice"); 
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Mount Gyros.prefab")]
    private static void MenuItem103() {
        Debug.Log("Selected item: Mount Gyros");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Mount Gyros"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Hulls/Solomon Battleship.prefab")]
    private static void MenuItem104() {
        Debug.Log("Selected item: Solomon Battleship");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Solomon Battleship"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Components/RM50 'Parallax' Radar.prefab")]
    private static void MenuItem105() {
        Debug.Log("Selected item: RM50 'Parallax' Radar");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("RM50 'Parallax' Radar"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Components/Light Civilian Reactor.prefab")]
    private static void MenuItem106() {
        Debug.Log("Selected item: Light Civilian Reactor");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Light Civilian Reactor"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Munitions/120mm HE Shell.asset")]
    private static void MenuItem107() {
        Debug.Log("Selected item: 120mm HE Shell");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("120mm HE Shell holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("120mm HE Shell"); 
        
    }

    [MenuItem("Load Asset/Stock/Debuffs/Magazine Cookoff.asset")]
    private static void MenuItem108() {
        Debug.Log("Selected item: Magazine Cookoff");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Magazine Cookoff holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Magazine Cookoff"); 
        
    }

    [MenuItem("Load Asset/Stock/F1/Components/Signature Scrambler.prefab")]
    private static void MenuItem109() {
        Debug.Log("Selected item: Signature Scrambler");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Signature Scrambler"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Weapons/C65 Cannon.prefab")]
    private static void MenuItem110() {
        Debug.Log("Selected item: C65 Cannon");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("C65 Cannon"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Munitions/Missile Components/Hardened Skin.asset")]
    private static void MenuItem111() {
        Debug.Log("Selected item: Hardened Skin");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Hardened Skin holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Hardened Skin"); 
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Rapid DC Locker.prefab")]
    private static void MenuItem112() {
        Debug.Log("Selected item: Rapid DC Locker");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Rapid DC Locker"));
        
    }

    [MenuItem("Load Asset/Stock/Voices/Lauren Voice.asset")]
    private static void MenuItem113() {
        Debug.Log("Selected item: Lauren Voice");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Lauren Voice holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Lauren Voice"); 
        
    }

    [MenuItem("Load Asset/Stock/F2/Weapons/C30 Cannon.prefab")]
    private static void MenuItem114() {
        Debug.Log("Selected item: C30 Cannon");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("C30 Cannon"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Munitions/M-30-N 'Mattock' Cooperative Mine.prefab")]
    private static void MenuItem115() {
        Debug.Log("Selected item: M-30-N 'Mattock' Cooperative Mine");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("M-30-N 'Mattock' Cooperative Mine"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Munitions/Missile Components/Self-Screening Jammer.asset")]
    private static void MenuItem116() {
        Debug.Log("Selected item: Self-Screening Jammer");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Self-Screening Jammer holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Self-Screening Jammer"); 
        
    }

    [MenuItem("Load Asset/Stock/F2/Munitions/400mm Plasma Ampoule.asset")]
    private static void MenuItem117() {
        Debug.Log("Selected item: 400mm Plasma Ampoule");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("400mm Plasma Ampoule holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("400mm Plasma Ampoule"); 
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Bulk Magazine.prefab")]
    private static void MenuItem118() {
        Debug.Log("Selected item: Bulk Magazine");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Bulk Magazine"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Launcher Deluge System.prefab")]
    private static void MenuItem119() {
        Debug.Log("Selected item: Launcher Deluge System");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Launcher Deluge System"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Weapons/Container Stack Launcher.prefab")]
    private static void MenuItem120() {
        Debug.Log("Selected item: Container Stack Launcher");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Container Stack Launcher"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Munitions/SGM-1/SGM-1 Body.prefab")]
    private static void MenuItem121() {
        Debug.Log("Selected item: SGM-1 Body");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("SGM-1 Body"));
        
    }

    [MenuItem("Load Asset/Stock/Munitions/SGM-233 Gale.prefab")]
    private static void MenuItem122() {
        Debug.Log("Selected item: SGM-233 Gale");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("SGM-233 Gale"));
        
    }

    [MenuItem("Load Asset/Stock/Debuffs/Container Bank Explosion.asset")]
    private static void MenuItem123() {
        Debug.Log("Selected item: Container Bank Explosion");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Container Bank Explosion holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Container Bank Explosion"); 
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Battle Dressing Station.prefab")]
    private static void MenuItem124() {
        Debug.Log("Selected item: Battle Dressing Station");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Battle Dressing Station"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Munitions/R-2 'Piranha' Rocket.prefab")]
    private static void MenuItem125() {
        Debug.Log("Selected item: R-2 'Piranha' Rocket");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("R-2 'Piranha' Rocket"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Weapons/E90 'Blanket' Jammer.prefab")]
    private static void MenuItem126() {
        Debug.Log("Selected item: E90 'Blanket' Jammer");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("E90 'Blanket' Jammer"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Rapid-Cycle Cradle.prefab")]
    private static void MenuItem127() {
        Debug.Log("Selected item: Rapid-Cycle Cradle");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Rapid-Cycle Cradle"));
        
    }

    [MenuItem("Load Asset/Stock/Missions/Harsh Winds Blow.asset")]
    private static void MenuItem128() {
        Debug.Log("Selected item: Harsh Winds Blow");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Harsh Winds Blow holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Harsh Winds Blow"); 
        
    }

    [MenuItem("Load Asset/Stock/F2/Weapons/R550 Early Warning Radar.prefab")]
    private static void MenuItem129() {
        Debug.Log("Selected item: R550 Early Warning Radar");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("R550 Early Warning Radar"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Weapons/Container Bank Launcher.prefab")]
    private static void MenuItem130() {
        Debug.Log("Selected item: Container Bank Launcher");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Container Bank Launcher"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Weapons/Mk550 Mass Driver.prefab")]
    private static void MenuItem131() {
        Debug.Log("Selected item: Mk550 Mass Driver");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Mk550 Mass Driver"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Munitions/Missile Components/Direct Guidance.asset")]
    private static void MenuItem132() {
        Debug.Log("Selected item: Direct Guidance");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Direct Guidance holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Direct Guidance"); 
        
    }

    [MenuItem("Load Asset/Stock/F2/Hulls/Container Line Ship.prefab")]
    private static void MenuItem133() {
        Debug.Log("Selected item: Container Line Ship");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Container Line Ship"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Weapons/E57 'Floodlight' Illuminator.prefab")]
    private static void MenuItem134() {
        Debug.Log("Selected item: E57 'Floodlight' Illuminator");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("E57 'Floodlight' Illuminator"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Weapons/Mk68 Cannon.prefab")]
    private static void MenuItem135() {
        Debug.Log("Selected item: Mk68 Cannon");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Mk68 Cannon"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Weapons/Mk95 'Sarissa' PDT.prefab")]
    private static void MenuItem136() {
        Debug.Log("Selected item: Mk95 'Sarissa' PDT");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Mk95 'Sarissa' PDT"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Munitions/100mm HE-HC Shell.asset")]
    private static void MenuItem137() {
        Debug.Log("Selected item: 100mm HE-HC Shell");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("100mm HE-HC Shell holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("100mm HE-HC Shell"); 
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Small Reactor Booster.prefab")]
    private static void MenuItem138() {
        Debug.Log("Selected item: Small Reactor Booster");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Small Reactor Booster"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Weapons/E30 Illuminator.prefab")]
    private static void MenuItem139() {
        Debug.Log("Selected item: E30 Illuminator");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("E30 Illuminator"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Weapons/VLS-2 Launcher.prefab")]
    private static void MenuItem140() {
        Debug.Log("Selected item: VLS-2 Launcher");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("VLS-2 Launcher"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Weapons/E70 'Interruption' Jammer.prefab")]
    private static void MenuItem141() {
        Debug.Log("Selected item: E70 'Interruption' Jammer");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("E70 'Interruption' Jammer"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Reinforced CIC.prefab")]
    private static void MenuItem142() {
        Debug.Log("Selected item: Reinforced CIC");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Reinforced CIC"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Weapons/E15 'Masquerade' Signature Booster.prefab")]
    private static void MenuItem143() {
        Debug.Log("Selected item: E15 'Masquerade' Signature Booster");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("E15 'Masquerade' Signature Booster"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Small Workshop.prefab")]
    private static void MenuItem144() {
        Debug.Log("Selected item: Small Workshop");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Small Workshop"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Munitions/CM-4D2 Decoy Container (Line Ship).prefab")]
    private static void MenuItem145() {
        Debug.Log("Selected item: CM-4D2 Decoy Container (Line Ship)");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("CM-4D2 Decoy Container (Line Ship)"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Strobe Correlator.prefab")]
    private static void MenuItem146() {
        Debug.Log("Selected item: Strobe Correlator");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Strobe Correlator"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Weapons/L50 'Blackjack' Laser Dazzler.prefab")]
    private static void MenuItem147() {
        Debug.Log("Selected item: L50 'Blackjack' Laser Dazzler");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("L50 'Blackjack' Laser Dazzler"));
        
    }

    [MenuItem("Load Asset/Stock/Maps/Pillars.prefab")]
    private static void MenuItem148() {
        Debug.Log("Selected item: Pillars");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Pillars"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Focused Particle Accelerator.prefab")]
    private static void MenuItem149() {
        Debug.Log("Selected item: Focused Particle Accelerator");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Focused Particle Accelerator"));
        
    }

    [MenuItem("Load Asset/Stock/Debuffs/Main Bus Short.asset")]
    private static void MenuItem150() {
        Debug.Log("Selected item: Main Bus Short");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Main Bus Short holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Main Bus Short"); 
        
    }

    [MenuItem("Load Asset/Stock/Maps/Shooting Gallery.prefab")]
    private static void MenuItem151() {
        Debug.Log("Selected item: Shooting Gallery");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Shooting Gallery"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Munitions/Missile Components/Steerable Extended Active Radar Seeker.asset")]
    private static void MenuItem152() {
        Debug.Log("Selected item: Steerable Extended Active Radar Seeker");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Steerable Extended Active Radar Seeker holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Steerable Extended Active Radar Seeker"); 
        
    }

    [MenuItem("Load Asset/Stock/Debuffs/Cell Launcher Cookoff.asset")]
    private static void MenuItem153() {
        Debug.Log("Selected item: Cell Launcher Cookoff");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Cell Launcher Cookoff holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Cell Launcher Cookoff"); 
        
    }

    [MenuItem("Load Asset/Stock/Common/Munitions/Missile Components/Cruise Guidance.asset")]
    private static void MenuItem154() {
        Debug.Log("Selected item: Cruise Guidance");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Cruise Guidance holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Cruise Guidance"); 
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Gun Plotting Center.prefab")]
    private static void MenuItem155() {
        Debug.Log("Selected item: Gun Plotting Center");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Gun Plotting Center"));
        
    }

    [MenuItem("Load Asset/Stock/Debuffs/Reactor Overload.asset")]
    private static void MenuItem156() {
        Debug.Log("Selected item: Reactor Overload");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Reactor Overload holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Reactor Overload"); 
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Adaptive Radar Receiver.prefab")]
    private static void MenuItem157() {
        Debug.Log("Selected item: Adaptive Radar Receiver");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Adaptive Radar Receiver"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Large DC Locker.prefab")]
    private static void MenuItem158() {
        Debug.Log("Selected item: Large DC Locker");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Large DC Locker"));
        
    }

    [MenuItem("Load Asset/Stock/Maps/Eye.prefab")]
    private static void MenuItem159() {
        Debug.Log("Selected item: Eye");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Eye"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Components/CR70 Antenna.prefab")]
    private static void MenuItem160() {
        Debug.Log("Selected item: CR70 Antenna");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("CR70 Antenna"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Supplementary Radio Amplifiers.prefab")]
    private static void MenuItem161() {
        Debug.Log("Selected item: Supplementary Radio Amplifiers");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Supplementary Radio Amplifiers"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Components/Large DC Storage.prefab")]
    private static void MenuItem162() {
        Debug.Log("Selected item: Large DC Storage");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Large DC Storage"));
        
    }

    [MenuItem("Load Asset/Stock/Maps/Abyssal.prefab")]
    private static void MenuItem163() {
        Debug.Log("Selected item: Abyssal");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Abyssal"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Munitions/100mm AP Shell.asset")]
    private static void MenuItem164() {
        Debug.Log("Selected item: 100mm AP Shell");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("100mm AP Shell holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("100mm AP Shell"); 
        
    }

    [MenuItem("Load Asset/Stock/Munitions/SDM-112 Riposte.prefab")]
    private static void MenuItem165() {
        Debug.Log("Selected item: SDM-112 Riposte");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("SDM-112 Riposte"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Weapons/C60 Cannon.prefab")]
    private static void MenuItem166() {
        Debug.Log("Selected item: C60 Cannon");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("C60 Cannon"));
        
    }

    [MenuItem("Load Asset/Stock/Munitions/SGM-206 Thunderhead.prefab")]
    private static void MenuItem167() {
        Debug.Log("Selected item: SGM-206 Thunderhead");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("SGM-206 Thunderhead"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Munitions/Missile Components/Fixed Anti-Radiation Seeker.asset")]
    private static void MenuItem168() {
        Debug.Log("Selected item: Fixed Anti-Radiation Seeker");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Fixed Anti-Radiation Seeker holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Fixed Anti-Radiation Seeker"); 
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Missile Programming Bus Array.prefab")]
    private static void MenuItem169() {
        Debug.Log("Selected item: Missile Programming Bus Array");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Missile Programming Bus Array"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Weapons/MLS-3 Launcher.prefab")]
    private static void MenuItem170() {
        Debug.Log("Selected item: MLS-3 Launcher");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("MLS-3 Launcher"));
        
    }

    [MenuItem("Load Asset/Stock/Debuffs/Focusing Element Misaligned.asset")]
    private static void MenuItem171() {
        Debug.Log("Selected item: Focusing Element Misaligned");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Focusing Element Misaligned holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Focusing Element Misaligned"); 
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Reinforced Thruster Nozzles.prefab")]
    private static void MenuItem172() {
        Debug.Log("Selected item: Reinforced Thruster Nozzles");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Reinforced Thruster Nozzles"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Weapons/J360 'Lyrebird' Jammer.prefab")]
    private static void MenuItem173() {
        Debug.Log("Selected item: J360 'Lyrebird' Jammer");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("J360 'Lyrebird' Jammer"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Weapons/J15 'Bellbird' Jammer.prefab")]
    private static void MenuItem174() {
        Debug.Log("Selected item: J15 'Bellbird' Jammer");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("J15 'Bellbird' Jammer"));
        
    }

    [MenuItem("Load Asset/Stock/Debuffs/Magazine Explosion Event.asset")]
    private static void MenuItem175() {
        Debug.Log("Selected item: Magazine Explosion Event");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Magazine Explosion Event holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Magazine Explosion Event"); 
        
    }

    [MenuItem("Load Asset/Stock/F1/Components/RS35 'Frontline' Radar.prefab")]
    private static void MenuItem176() {
        Debug.Log("Selected item: RS35 'Frontline' Radar");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("RS35 'Frontline' Radar"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Weapons/RF44 'Pinpoint' Radar.prefab")]
    private static void MenuItem177() {
        Debug.Log("Selected item: RF44 'Pinpoint' Radar");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("RF44 'Pinpoint' Radar"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Drives/CHI-777 Yard Drive.prefab")]
    private static void MenuItem178() {
        Debug.Log("Selected item: CHI-777 Yard Drive");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("CHI-777 Yard Drive"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Munitions/250mm AP Shell.asset")]
    private static void MenuItem179() {
        Debug.Log("Selected item: 250mm AP Shell");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("250mm AP Shell holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("250mm AP Shell"); 
        
    }

    [MenuItem("Load Asset/Stock/Maps/Cliff.prefab")]
    private static void MenuItem180() {
        Debug.Log("Selected item: Cliff");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Cliff"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Munitions/100mm Grape.asset")]
    private static void MenuItem181() {
        Debug.Log("Selected item: 100mm Grape");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("100mm Grape holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("100mm Grape"); 
        
    }

    [MenuItem("Load Asset/Stock/Voices/Jane Voice.asset")]
    private static void MenuItem182() {
        Debug.Log("Selected item: Jane Voice");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Jane Voice holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Jane Voice"); 
        
    }

    [MenuItem("Load Asset/Stock/F1/Munitions/120mm AP Shell.asset")]
    private static void MenuItem183() {
        Debug.Log("Selected item: 120mm AP Shell");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("120mm AP Shell holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("120mm AP Shell"); 
        
    }

    [MenuItem("Load Asset/Stock/F2/Drives/CHI-9100 Long Haul Drive.prefab")]
    private static void MenuItem184() {
        Debug.Log("Selected item: CHI-9100 Long Haul Drive");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("CHI-9100 Long Haul Drive"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Munitions/EA20 Flare Decoy.prefab")]
    private static void MenuItem185() {
        Debug.Log("Selected item: EA20 Flare Decoy");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("EA20 Flare Decoy"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Munitions/120mm HE-RPF Shell.asset")]
    private static void MenuItem186() {
        Debug.Log("Selected item: 120mm HE-RPF Shell");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("120mm HE-RPF Shell holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("120mm HE-RPF Shell"); 
        
    }

    [MenuItem("Load Asset/Stock/F2/Drives/BW2000 Drive.prefab")]
    private static void MenuItem187() {
        Debug.Log("Selected item: BW2000 Drive");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("BW2000 Drive"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Berthing.prefab")]
    private static void MenuItem188() {
        Debug.Log("Selected item: Berthing");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Berthing"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Weapons/VLS-1-23 Launcher.prefab")]
    private static void MenuItem189() {
        Debug.Log("Selected item: VLS-1-23 Launcher");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("VLS-1-23 Launcher"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Munitions/SGM-2/SGM-2 Body.prefab")]
    private static void MenuItem190() {
        Debug.Log("Selected item: SGM-2 Body");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("SGM-2 Body"));
        
    }

    [MenuItem("Load Asset/Stock/Debuffs/Heatsink Ruptured.asset")]
    private static void MenuItem191() {
        Debug.Log("Selected item: Heatsink Ruptured");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Heatsink Ruptured holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Heatsink Ruptured"); 
        
    }

    [MenuItem("Load Asset/Stock/F2/Weapons/C53 Cannon.prefab")]
    private static void MenuItem192() {
        Debug.Log("Selected item: C53 Cannon");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("C53 Cannon"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Missile Parallel Interface.prefab")]
    private static void MenuItem193() {
        Debug.Log("Selected item: Missile Parallel Interface");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Missile Parallel Interface"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Analysis Annex.prefab")]
    private static void MenuItem194() {
        Debug.Log("Selected item: Analysis Annex");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Analysis Annex"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Drives/BW1500 Drive.prefab")]
    private static void MenuItem195() {
        Debug.Log("Selected item: BW1500 Drive");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("BW1500 Drive"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Weapons/RL18 Launcher.prefab")]
    private static void MenuItem196() {
        Debug.Log("Selected item: RL18 Launcher");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("RL18 Launcher"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Weapons/E71 'Hangup' Jammer.prefab")]
    private static void MenuItem197() {
        Debug.Log("Selected item: E71 'Hangup' Jammer");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("E71 'Hangup' Jammer"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Munitions/Missile Components/HE Impact.asset")]
    private static void MenuItem198() {
        Debug.Log("Selected item: HE Impact");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("HE Impact holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("HE Impact"); 
        
    }

    [MenuItem("Load Asset/Stock/F1/Munitions/Flak Round.asset")]
    private static void MenuItem199() {
        Debug.Log("Selected item: Flak Round");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Flak Round holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Flak Round"); 
        
    }

    [MenuItem("Load Asset/Stock/Common/Munitions/Missile Components/Steerable Active Radar Seeker.asset")]
    private static void MenuItem200() {
        Debug.Log("Selected item: Steerable Active Radar Seeker");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Steerable Active Radar Seeker holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Steerable Active Radar Seeker"); 
        
    }

    [MenuItem("Load Asset/Stock/F2/Munitions/100mm HE Shell.asset")]
    private static void MenuItem201() {
        Debug.Log("Selected item: 100mm HE Shell");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("100mm HE Shell holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("100mm HE Shell"); 
        
    }

    [MenuItem("Load Asset/Stock/Common/Munitions/Missile Components/Boosted Self-Screening Jammer.asset")]
    private static void MenuItem202() {
        Debug.Log("Selected item: Boosted Self-Screening Jammer");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Boosted Self-Screening Jammer holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Boosted Self-Screening Jammer"); 
        
    }

    [MenuItem("Load Asset/Stock/F1/Weapons/Mk66 Cannon.prefab")]
    private static void MenuItem203() {
        Debug.Log("Selected item: Mk66 Cannon");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Mk66 Cannon"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Munitions/Missile Components/Fixed Semi-Active Radar Seeker.asset")]
    private static void MenuItem204() {
        Debug.Log("Selected item: Fixed Semi-Active Radar Seeker");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Fixed Semi-Active Radar Seeker holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Fixed Semi-Active Radar Seeker"); 
        
    }

    [MenuItem("Load Asset/Stock/Munitions/SGM-225 Hurricane.prefab")]
    private static void MenuItem205() {
        Debug.Log("Selected item: SGM-225 Hurricane");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("SGM-225 Hurricane"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Weapons/Mk25 'Rebound' PDT.prefab")]
    private static void MenuItem206() {
        Debug.Log("Selected item: Mk25 'Rebound' PDT");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Mk25 'Rebound' PDT"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Weapons/E20 'Lighthouse' Illuminator.prefab")]
    private static void MenuItem207() {
        Debug.Log("Selected item: E20 'Lighthouse' Illuminator");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("E20 'Lighthouse' Illuminator"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Citadel CIC.prefab")]
    private static void MenuItem208() {
        Debug.Log("Selected item: Citadel CIC");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Citadel CIC"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Small DC Locker.prefab")]
    private static void MenuItem209() {
        Debug.Log("Selected item: Small DC Locker");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Small DC Locker"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Components/RS41 'Spyglass' Radar.prefab")]
    private static void MenuItem210() {
        Debug.Log("Selected item: RS41 'Spyglass' Radar");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("RS41 'Spyglass' Radar"));
        
    }

    [MenuItem("Load Asset/Stock/Munitions/SGT-350 Mace.prefab")]
    private static void MenuItem211() {
        Debug.Log("Selected item: SGT-350 Mace");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("SGT-350 Mace"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Munitions/Missile Components/Command Receiver.asset")]
    private static void MenuItem212() {
        Debug.Log("Selected item: Command Receiver");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Command Receiver holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Command Receiver"); 
        
    }

    [MenuItem("Load Asset/Stock/Scenarios/Tug Of War.asset")]
    private static void MenuItem213() {
        Debug.Log("Selected item: Tug Of War");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Tug Of War holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Tug Of War"); 
        
    }

    [MenuItem("Load Asset/Stock/Scenarios/Deathmatch.asset")]
    private static void MenuItem214() {
        Debug.Log("Selected item: Deathmatch");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Deathmatch holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Deathmatch"); 
        
    }

    [MenuItem("Load Asset/Stock/F1/Weapons/E55 'Spotlight' Illuminator.prefab")]
    private static void MenuItem215() {
        Debug.Log("Selected item: E55 'Spotlight' Illuminator");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("E55 'Spotlight' Illuminator"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Reinforced Magazine.prefab")]
    private static void MenuItem216() {
        Debug.Log("Selected item: Reinforced Magazine");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Reinforced Magazine"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Components/Civilian Reactor.prefab")]
    private static void MenuItem217() {
        Debug.Log("Selected item: Civilian Reactor");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Civilian Reactor"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Basic CIC.prefab")]
    private static void MenuItem218() {
        Debug.Log("Selected item: Basic CIC");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Basic CIC"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Drives/Sundrive Racing Pro.prefab")]
    private static void MenuItem219() {
        Debug.Log("Selected item: Sundrive Racing Pro");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Sundrive Racing Pro"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Weapons/T81 Plasma Cannon.prefab")]
    private static void MenuItem220() {
        Debug.Log("Selected item: T81 Plasma Cannon");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("T81 Plasma Cannon"));
        
    }

    [MenuItem("Load Asset/Stock/Voices/Solestine Voice.asset")]
    private static void MenuItem221() {
        Debug.Log("Selected item: Solestine Voice");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Solestine Voice holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Solestine Voice"); 
        
    }

    [MenuItem("Load Asset/Stock/Debuffs/Sensor Oscillator Drift.asset")]
    private static void MenuItem222() {
        Debug.Log("Selected item: Sensor Oscillator Drift");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Sensor Oscillator Drift holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Sensor Oscillator Drift"); 
        
    }

    [MenuItem("Load Asset/Stock/F1/Munitions/20mm Slug.asset")]
    private static void MenuItem223() {
        Debug.Log("Selected item: 20mm Slug");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("20mm Slug holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("20mm Slug"); 
        
    }

    [MenuItem("Load Asset/Stock/Maps/Maze.prefab")]
    private static void MenuItem224() {
        Debug.Log("Selected item: Maze");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Maze"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Weapons/VLS-3 Launcher.prefab")]
    private static void MenuItem225() {
        Debug.Log("Selected item: VLS-3 Launcher");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("VLS-3 Launcher"));
        
    }

    [MenuItem("Load Asset/Stock/Scenarios/Control.asset")]
    private static void MenuItem226() {
        Debug.Log("Selected item: Control");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Control holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Control"); 
        
    }

    [MenuItem("Load Asset/Stock/F1/Munitions/SGM-H-2/SGM-H-2 Body.prefab")]
    private static void MenuItem227() {
        Debug.Log("Selected item: SGM-H-2 Body");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("SGM-H-2 Body"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Ammunition Elevators.prefab")]
    private static void MenuItem228() {
        Debug.Log("Selected item: Ammunition Elevators");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Ammunition Elevators"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Components/Bulwark Huntress.prefab")]
    private static void MenuItem229() {
        Debug.Log("Selected item: Bulwark Huntress");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Bulwark Huntress"));
        
    }

    [MenuItem("Load Asset/Stock/Voices/Marshall Voice.asset")]
    private static void MenuItem230() {
        Debug.Log("Selected item: Marshall Voice");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Marshall Voice holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Marshall Voice"); 
        
    }

    [MenuItem("Load Asset/Stock/Debuffs/Sensor Antenna Bent.asset")]
    private static void MenuItem231() {
        Debug.Log("Selected item: Sensor Antenna Bent");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Sensor Antenna Bent holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Sensor Antenna Bent"); 
        
    }

    [MenuItem("Load Asset/Stock/F1/Drives/FM200R Drive.prefab")]
    private static void MenuItem232() {
        Debug.Log("Selected item: FM200R Drive");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("FM200R Drive"));
        
    }

    [MenuItem("Load Asset/Stock/Debuffs/Fuel Line Fire.asset")]
    private static void MenuItem233() {
        Debug.Log("Selected item: Fuel Line Fire");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Fuel Line Fire holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Fuel Line Fire"); 
        
    }

    [MenuItem("Load Asset/Stock/F1/Weapons/Mk600 Beam Cannon.prefab")]
    private static void MenuItem234() {
        Debug.Log("Selected item: Mk600 Beam Cannon");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Mk600 Beam Cannon"));
        
    }

    [MenuItem("Load Asset/Stock/Scenarios/Two Flags.asset")]
    private static void MenuItem235() {
        Debug.Log("Selected item: Two Flags");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Two Flags holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Two Flags"); 
        
    }

    [MenuItem("Load Asset/Stock/Debuffs/Gyro Drift.asset")]
    private static void MenuItem236() {
        Debug.Log("Selected item: Gyro Drift");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Gyro Drift holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Gyro Drift"); 
        
    }

    [MenuItem("Load Asset/Stock/F2/Munitions/CM-4/CM-4 Body.prefab")]
    private static void MenuItem237() {
        Debug.Log("Selected item: CM-4 Body");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("CM-4 Body"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Drives/CHI-7700 Drive.prefab")]
    private static void MenuItem238() {
        Debug.Log("Selected item: CHI-7700 Drive");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("CHI-7700 Drive"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Weapons/ML-9 Mine Launcher.prefab")]
    private static void MenuItem239() {
        Debug.Log("Selected item: ML-9 Mine Launcher");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("ML-9 Mine Launcher"));
        
    }

    [MenuItem("Load Asset/Stock/Maps/Canyon.prefab")]
    private static void MenuItem240() {
        Debug.Log("Selected item: Canyon");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Canyon"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Weapons/MLS-2 Launcher.prefab")]
    private static void MenuItem241() {
        Debug.Log("Selected item: MLS-2 Launcher");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("MLS-2 Launcher"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Weapons/T30 Cannon.prefab")]
    private static void MenuItem242() {
        Debug.Log("Selected item: T30 Cannon");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("T30 Cannon"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Faction Alliance.asset")]
    private static void MenuItem243() {
        Debug.Log("Selected item: Faction Alliance");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Faction Alliance holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Faction Alliance"); 
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Auxiliary Steering.prefab")]
    private static void MenuItem244() {
        Debug.Log("Selected item: Auxiliary Steering");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Auxiliary Steering"));
        
    }

    [MenuItem("Load Asset/Stock/F2/Drives/BW800 Drive.prefab")]
    private static void MenuItem245() {
        Debug.Log("Selected item: BW800 Drive");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("BW800 Drive"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Weapons/Mk64 Cannon.prefab")]
    private static void MenuItem246() {
        Debug.Log("Selected item: Mk64 Cannon");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Mk64 Cannon"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Weapons/ES22 'Pinard' Electronic Support Module.prefab")]
    private static void MenuItem247() {
        Debug.Log("Selected item: ES22 'Pinard' Electronic Support Module");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("ES22 'Pinard' Electronic Support Module"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Actively Cooled Amplifiers.prefab")]
    private static void MenuItem248() {
        Debug.Log("Selected item: Actively Cooled Amplifiers");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Actively Cooled Amplifiers"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Drives/FM280 'Raider' Drive.prefab")]
    private static void MenuItem249() {
        Debug.Log("Selected item: FM280 'Raider' Drive");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("FM280 'Raider' Drive"));
        
    }

    [MenuItem("Load Asset/Stock/F1/Weapons/Mk62 Cannon.prefab")]
    private static void MenuItem250() {
        Debug.Log("Selected item: Mk62 Cannon");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Mk62 Cannon"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Components/Damage Control Central.prefab")]
    private static void MenuItem251() {
        Debug.Log("Selected item: Damage Control Central");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        Instantiate(stock.LoadAsset<GameObject>("Damage Control Central"));
        
    }

    [MenuItem("Load Asset/Stock/Common/Munitions/Missile Components/Electro-Optical Seeker.asset")]
    private static void MenuItem252() {
        Debug.Log("Selected item: Electro-Optical Seeker");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("Electro-Optical Seeker holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("Electro-Optical Seeker"); 
        
    }

    [MenuItem("Load Asset/Stock/F2/Munitions/250mm HE-HC Shell.asset")]
    private static void MenuItem253() {
        Debug.Log("Selected item: 250mm HE-HC Shell");
        if (stock == null)
            stock = AssetBundle.LoadFromFile(Path.Combine(Application.dataPath + "/Tool/AssetBundles/stock"));
        GameObject goh = new GameObject("250mm HE-HC Shell holder");
        goh.AddComponent<Holder>().a = stock.LoadAsset<ScriptableObject>("250mm HE-HC Shell"); 
        
    }


}
