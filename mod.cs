using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System.Collections;
using System;

namespace Ninjago
{
    public class Mod : MonoBehaviour
    {
        public static string ModTag = " [NG]";

        public static void Main()
        {
            CategoryBuilder.Create("Ninjago", "Everything Ninjago", ModAPI.LoadSprite("sprites/ninjago.png"));

            #region People

            //Kai
            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Human"),
                NameOverride = "Kai" + ModTag,
                DescriptionOverride = "Ninja of fire.",
                CategoryOverride = ModAPI.FindCategory("Ninjago"),
                NameToOrderByOverride = "1",
                ThumbnailOverride = ModAPI.LoadSprite("sprites/Thumbnails/kaiThumbnail.png"), 
                AfterSpawn = (Instance) =>
                {
                    var skin = ModAPI.LoadTexture("sprites/Kai/kai.png");
                    Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin);

                    var head = Instance.transform.GetChild(5);
                    var childObject = new GameObject("Hair");
                    childObject.transform.SetParent(head);
                    childObject.transform.localPosition = new Vector3(0, -0.0275f);
                    childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    childObject.transform.localScale = new Vector3(1f, 1f);
                    var childSprite = childObject.AddComponent<SpriteRenderer>();
                    childSprite.sprite = ModAPI.LoadSprite("sprites/empty.png");
                    childSprite.sortingLayerName = "Top";

                    var person = Instance.GetComponent<PersonBehaviour>();
                    foreach (var body in person.Limbs)
                    {
                        body.DiscomfortingHeatTemperature = float.MaxValue;
                        body.PhysicalBehaviour.BurningProgressionMultiplier = 0;

                        body.gameObject.AddComponent<CycleSkinTextures>();
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Kai/kai.png"), true, "Original", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Kai/kaiMaskless.png"), true, "Original (No Mask)", ModAPI.LoadSprite("sprites/Kai/kaiHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Kai/kaiDX.png"), true, "DX", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Kai/kaiDXMaskless.png"), true, "DX (No Mask)", ModAPI.LoadSprite("sprites/Kai/kaiHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Kai/kaiZX.png"), true, "ZX", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Kai/kaiZXMaskless.png"), true, "ZX (No Mask)", ModAPI.LoadSprite("sprites/Kai/kaiHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Kai/kaiElemental.png"), true, "Elemental", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Kai/kaiElementalMaskless.png"), true, "Elemental (No Mask)", ModAPI.LoadSprite("sprites/Kai/kaiHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Kai/kaiTechno.png"), true, "Techno", ModAPI.LoadSprite("sprites/Kai/kaiHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Kai/kaiTechnoMaskless.png"), true, "Techno (No Mask)", ModAPI.LoadSprite("sprites/Kai/kaiHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Kai/kaiStoneArmor.png"), true, "Stone Armor", ModAPI.LoadSprite("sprites/Kai/kaiHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Kai/kaiStoneArmorMaskless.png"), true, "Stone Armor (No Mask)", ModAPI.LoadSprite("sprites/Kai/kaiHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Kai/kaiTournament.png"), true, "Tournament", ModAPI.LoadSprite("sprites/Kai/kaiHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Kai/kaiTournamentMaskless.png"), true, "Tournament (No Mask)", ModAPI.LoadSprite("sprites/Kai/kaiHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Kai/kaiJungle.png"), true, "Jungle", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Kai/kaiJungleMaskless.png"), true, "Jungle (No Mask)", ModAPI.LoadSprite("sprites/Kai/kaiHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Kai/kaiDeepstone.png"), true, "Deepstone", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Kai/kaiDeepstoneMaskless.png"), true, "Deepstone (No Mask)", ModAPI.LoadSprite("sprites/Kai/kaiHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Kai/kaiDestiny.png"), true, "Destiny", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Kai/kaiDestinyMaskless.png"), true, "Destiny (No Mask)", ModAPI.LoadSprite("sprites/Kai/kaiHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Kai/kaiHonor.png"), true, "Honor", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Kai/kaiHonorMaskless.png"), true, "Honor (No Mask)", ModAPI.LoadSprite("sprites/Kai/kaiHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Kai/kaiFusion.png"), true, "Fusion", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Kai/kaiFusionMaskless.png"), true, "Fusion (No Mask)", ModAPI.LoadSprite("sprites/Kai/kaiHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Kai/kaiResistance.png"), true, "Resistance", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Kai/kaiResistanceMaskless.png"), true, "Resistance (No Mask)", ModAPI.LoadSprite("sprites/Kai/kaiLegacyHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Kai/kaiHunted.png"), ModAPI.LoadTexture("sprites/Kai/kaiHuntedArm.png"), new string[] { "UpperArmFront", "LowerArmFront" }, true, "Hunted", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Kai/kaiHuntedMaskless.png"), ModAPI.LoadTexture("sprites/Kai/kaiHuntedArm.png"), new string[] { "UpperArmFront", "LowerArmFront" }, true, "Hunted (No Mask)", ModAPI.LoadSprite("sprites/Kai/kaiLegacyHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Kai/kaiLegacy.png"), true, "Legacy", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Kai/kaiLegacyMaskless.png"), true, "Legacy (No Mask)", ModAPI.LoadSprite("sprites/Kai/kaiLegacyHair.png"));

                        body.gameObject.AddComponent<HumanTorch>();
                    }
                }
            });

            //Jay
            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Human"),
                NameOverride = "Jay" + ModTag,
                DescriptionOverride = "Ninja of lightning.",
                CategoryOverride = ModAPI.FindCategory("Ninjago"),
                NameToOrderByOverride = "2",
                ThumbnailOverride = ModAPI.LoadSprite("sprites/Thumbnails/jayThumbnail.png"), 
                AfterSpawn = (Instance) =>
                {
                    var skin = ModAPI.LoadTexture("sprites/Jay/jay.png");
                    Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin);

                    var head = Instance.transform.GetChild(5);
                    var childObject = new GameObject("Hair");
                    childObject.transform.SetParent(head);
                    childObject.transform.localPosition = new Vector3(0, -0.0275f);
                    childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    childObject.transform.localScale = new Vector3(1f, 1f);
                    var childSprite = childObject.AddComponent<SpriteRenderer>();
                    childSprite.sprite = ModAPI.LoadSprite("sprites/empty.png");
                    childSprite.sortingLayerName = "Top";

                    var person = Instance.GetComponent<PersonBehaviour>();
                    foreach (var body in person.Limbs)
                    {
                        body.PhysicalBehaviour.ForceNoCharge = true;
                        body.PhysicalBehaviour.ChargeBurns = false;
                        body.PhysicalBehaviour.EnergyWireResistance = float.MaxValue;

                        body.gameObject.AddComponent<CycleSkinTextures>();
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Jay/jay.png"), true, "Original", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Jay/jayMaskless.png"), true, "Original (No Mask)", ModAPI.LoadSprite("sprites/Jay/jayHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Jay/jayDX.png"), true, "DX", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Jay/jayDXMaskless.png"), true, "DX (No Mask)", ModAPI.LoadSprite("sprites/Jay/jayHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Jay/jayZX.png"), ModAPI.LoadTexture("sprites/Jay/jayZXArm.png"), new string[] { "UpperArmFront", "LowerArmFront" }, true, "ZX", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Jay/jayZXMaskless.png"), ModAPI.LoadTexture("sprites/Jay/jayZXArm.png"), new string[] { "UpperArmFront", "LowerArmFront" }, true, "ZX (No Mask)", ModAPI.LoadSprite("sprites/Jay/jayHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Jay/jayElemental.png"), true, "Elemental", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Jay/jayElementalMaskless.png"), true, "Elemental (No Mask)", ModAPI.LoadSprite("sprites/Jay/jayHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Jay/jayTechno.png"), true, "Techno", ModAPI.LoadSprite("sprites/Jay/jayHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Jay/jayTechnoMaskless.png"), true, "Techno (No Mask)", ModAPI.LoadSprite("sprites/Jay/jayHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Jay/jayStoneArmor.png"), true, "Stone Armor", ModAPI.LoadSprite("sprites/Jay/jayHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Jay/jayStoneArmorMaskless.png"), true, "Stone Armor (No Mask)", ModAPI.LoadSprite("sprites/Jay/jayHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Jay/jayTournament.png"), true, "Tournament", ModAPI.LoadSprite("sprites/Jay/jayHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Jay/jayTournamentMaskless.png"), true, "Tournament (No Mask)", ModAPI.LoadSprite("sprites/Jay/jayHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Jay/jayJungle.png"), true, "Jungle", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Jay/jayJungleMaskless.png"), true, "Jungle (No Mask)", ModAPI.LoadSprite("sprites/Jay/jayHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Jay/jayDeepstone.png"), true, "Deepstone", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Jay/jayDeepstoneMaskless.png"), true, "Deepstone (No Mask)", ModAPI.LoadSprite("sprites/Jay/jayHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Jay/jayDestiny.png"), true, "Destiny", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Jay/jayDestinyMaskless.png"), true, "Destiny (No Mask)", ModAPI.LoadSprite("sprites/Jay/jayHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Jay/jayHonor.png"), ModAPI.LoadTexture("sprites/Jay/jayHonorArm.png"), new string[] { "UpperArmFront", "LowerArmFront" }, true, "Honor", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Jay/jayHonorMaskless.png"), ModAPI.LoadTexture("sprites/Jay/jayHonorArm.png"), new string[] { "UpperArmFront", "LowerArmFront" }, true, "Honor (No Mask)", ModAPI.LoadSprite("sprites/Jay/jayHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Jay/jayFusion.png"), true, "Fusion", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Jay/jayFusionMaskless.png"), true, "Fusion (No Mask)", ModAPI.LoadSprite("sprites/Jay/jayHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Jay/jayResistance.png"), true, "Resistance", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Jay/jayResistanceMaskless.png"), true, "Resistance (No Mask)", ModAPI.LoadSprite("sprites/Jay/jayLegacyHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Jay/jayHunted.png"), true, "Hunted", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Jay/jayHuntedMaskless.png"), true, "Hunted (No Mask)", ModAPI.LoadSprite("sprites/Jay/jayLegacyHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Jay/jayLegacy.png"), true, "Legacy", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Jay/jayLegacyMaskless.png"), true, "Legacy (No Mask)", ModAPI.LoadSprite("sprites/Jay/jayLegacyHair.png"));
                    }
                }
            });
            
            //Cole
            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Human"),
                NameOverride = "Cole" + ModTag,
                DescriptionOverride = "Ninja of earth.",
                CategoryOverride = ModAPI.FindCategory("Ninjago"),
                NameToOrderByOverride = "3",
                ThumbnailOverride = ModAPI.LoadSprite("sprites/Thumbnails/coleThumbnail.png"), 
                AfterSpawn = (Instance) =>
                {
                    var skin = ModAPI.LoadTexture("sprites/Cole/cole.png");
                    Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin);

                    var head = Instance.transform.GetChild(5);
                    var childObject = new GameObject("Hair");
                    childObject.transform.SetParent(head);
                    childObject.transform.localPosition = new Vector3(0, -0.0275f);
                    childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    childObject.transform.localScale = new Vector3(1f, 1f);
                    var childSprite = childObject.AddComponent<SpriteRenderer>();
                    childSprite.sprite = ModAPI.LoadSprite("sprites/empty.png");
                    childSprite.sortingLayerName = "Top";

                    var person = Instance.GetComponent<PersonBehaviour>();
                    foreach (var body in person.Limbs)
                    {
                        body.gameObject.AddComponent<CycleSkinTextures>();
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/cole.png"), true, "Original", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/coleMaskless.png"), true, "Original (No Mask)", ModAPI.LoadSprite("sprites/Cole/coleHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/coleDX.png"), true, "DX", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/coleDXMaskless.png"), true, "DX (No Mask)", ModAPI.LoadSprite("sprites/Cole/coleHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/coleZX.png"), true, "ZX", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/coleZXMaskless.png"), true, "ZX (No Mask)", ModAPI.LoadSprite("sprites/Cole/coleHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/coleElemental.png"), true, "Elemental", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/coleElementalMaskless.png"), true, "Elemental (No Mask)", ModAPI.LoadSprite("sprites/Cole/coleHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/coleTechno.png"), true, "Techno", ModAPI.LoadSprite("sprites/Cole/coleHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/coleTechnoMaskless.png"), true, "Techno (No Mask)", ModAPI.LoadSprite("sprites/Cole/coleHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/coleStoneArmor.png"), true, "Stone Armor", ModAPI.LoadSprite("sprites/Cole/coleHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/coleStoneArmorMaskless.png"), true, "Stone Armor (No Mask)", ModAPI.LoadSprite("sprites/Cole/coleHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/coleTournament.png"), true, "Tournament", ModAPI.LoadSprite("sprites/Cole/coleHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/coleTournamentMaskless.png"), true, "Tournament (No Mask)", ModAPI.LoadSprite("sprites/Cole/coleHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/coleJungle.png"), true, "Jungle", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/coleJungleMaskless.png"), true, "Jungle (No Mask)", ModAPI.LoadSprite("sprites/Cole/coleHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/coleDeepstone.png"), true, "Deepstone", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/coleDeepstoneMaskless.png"), true, "Deepstone (No Mask)", ModAPI.LoadSprite("sprites/Cole/coleHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/coleDeepstoneGhost.png"), true, "Deepstone (Ghost)", ModAPI.LoadSprite("sprites/empty.png"), ModAPI.LoadTexture("sprites/Cole/ghostFlesh.png"), ModAPI.LoadTexture("sprites/Cole/ghostBone.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/coleDeepstoneGhostMaskless.png"), true, "Deepstone (Ghost, No Mask)", ModAPI.LoadSprite("sprites/Cole/coleHairGhost.png"), ModAPI.LoadTexture("sprites/Cole/ghostFlesh.png"), ModAPI.LoadTexture("sprites/Cole/ghostBone.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/coleDestiny.png"), true, "Destiny", ModAPI.LoadSprite("sprites/empty.png"), ModAPI.LoadTexture("sprites/Cole/ghostFlesh.png"), ModAPI.LoadTexture("sprites/Cole/ghostBone.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/coleDestinyMaskless.png"), true, "Destiny (No Mask)", ModAPI.LoadSprite("sprites/Cole/coleHairGhost.png"), ModAPI.LoadTexture("sprites/Cole/ghostFlesh.png"), ModAPI.LoadTexture("sprites/Cole/ghostBone.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/coleHonorGhost.png"), true, "Honor (Ghost)", ModAPI.LoadSprite("sprites/empty.png"), ModAPI.LoadTexture("sprites/Cole/ghostFlesh.png"), ModAPI.LoadTexture("sprites/Cole/ghostBone.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/coleHonorGhostMaskless.png"), true, "Honor (Ghost, No Mask)", ModAPI.LoadSprite("sprites/Cole/coleHairGhost.png"), ModAPI.LoadTexture("sprites/Cole/ghostFlesh.png"), ModAPI.LoadTexture("sprites/Cole/ghostBone.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/coleHonor.png"), true, "Honor", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/coleHonorMaskless.png"), true, "Honor (No Mask)", ModAPI.LoadSprite("sprites/Cole/coleHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/coleFusion.png"), true, "Fusion", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/coleFusionMaskless.png"), true, "Fusion (No Mask)", ModAPI.LoadSprite("sprites/Cole/coleHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/coleResistance.png"), true, "Resistance", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/coleResistanceMaskless.png"), true, "Resistance (No Mask)", ModAPI.LoadSprite("sprites/Cole/coleLegacyHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/coleHunted.png"), true, "Hunted", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/coleHuntedMaskless.png"), true, "Hunted (No Mask)", ModAPI.LoadSprite("sprites/Cole/coleLegacyHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/coleLegacy.png"), true, "Legacy", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Cole/coleLegacyMaskless.png"), true, "Legacy (No Mask)", ModAPI.LoadSprite("sprites/Cole/coleLegacyHair.png"));
                    }
                }
            });

            //Zane
            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Android"),
                NameOverride = "Zane" + ModTag,
                DescriptionOverride = "Ninja of ice.",
                CategoryOverride = ModAPI.FindCategory("Ninjago"),
                NameToOrderByOverride = "4",
                ThumbnailOverride = ModAPI.LoadSprite("sprites/Thumbnails/zaneThumbnail.png"), 
                AfterSpawn = (Instance) =>
                {
                    var skin = ModAPI.LoadTexture("sprites/Zane/zane.png");

                    var head = Instance.transform.GetChild(0);
                    var childObject = new GameObject("Hair");
                    childObject.transform.SetParent(head);
                    childObject.transform.localPosition = new Vector3(0, -0.0275f);
                    childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    childObject.transform.localScale = new Vector3(1f, 1f);
                    var childSprite = childObject.AddComponent<SpriteRenderer>();
                    childSprite.sprite = ModAPI.LoadSprite("sprites/empty.png");
                    childSprite.sortingLayerName = "Top";

                    var person = Instance.GetComponent<PersonBehaviour>();
                    person.RandomisedSize = true;
                    foreach (var body in person.Limbs)
                    {
                        body.gameObject.AddComponent<CycleSkinTextures>();
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zane.png"), true, "Original", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zaneMaskless.png"), true, "Original (No Mask)", ModAPI.LoadSprite("sprites/Zane/zaneHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zaneDX.png"), true, "DX", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zaneDXMaskless.png"), true, "DX (No Mask)", ModAPI.LoadSprite("sprites/Zane/zaneHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zaneZX.png"), true, "ZX", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zaneZXMaskless.png"), true, "ZX (No Mask)", ModAPI.LoadSprite("sprites/Zane/zaneHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zaneElemental.png"), true, "Elemental", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zaneElementalMaskless.png"), true, "Elemental (No Mask)", ModAPI.LoadSprite("sprites/Zane/zaneHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zanePink.png"), true, "Pink", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zanePinkMaskless.png"), true, "Pink (No Mask)", ModAPI.LoadSprite("sprites/Zane/zaneHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zaneTechno.png"), true, "Techno", ModAPI.LoadSprite("sprites/Zane/zaneHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zaneTechnoMaskless.png"), true, "Techno (No Mask)", ModAPI.LoadSprite("sprites/Zane/zaneHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zaneStoneArmor.png"), true, "Stone Armor", ModAPI.LoadSprite("sprites/Zane/zaneHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zaneStoneArmorMaskless.png"), true, "Stone Armor (No Mask)", ModAPI.LoadSprite("sprites/Zane/zaneHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zaneJungle.png"), true, "Jungle", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zaneJungleMaskless.png"), true, "Jungle (No Mask)", ModAPI.LoadSprite("sprites/Zane/zaneTitaniumHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zaneDeepstone.png"), true, "Deepstone", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zaneDeepstoneMaskless.png"), true, "Deepstone (No Mask)", ModAPI.LoadSprite("sprites/Zane/zaneTitaniumHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zaneDestiny.png"), true, "Destiny", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zaneDestinyMaskless.png"), true, "Destiny (No Mask)", ModAPI.LoadSprite("sprites/Zane/zaneTitaniumHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zaneHonor.png"), true, "Honor", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zaneHonorMaskless.png"), true, "Honor (No Mask)", ModAPI.LoadSprite("sprites/Zane/zaneTitaniumHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zaneFusion.png"), true, "Fusion", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zaneFusionMaskless.png"), true, "Fusion (No Mask)", ModAPI.LoadSprite("sprites/Zane/zaneTitaniumHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zaneResistance.png"), true, "Resistance", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zaneResistanceMaskless.png"), true, "Resistance (No Mask)", ModAPI.LoadSprite("sprites/Zane/zaneTitaniumLegacyHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zaneResistanceCloak.png"), true, "Resistance (Cloaked)", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zaneResistanceCloakMaskless.png"), true, "Resistance (Cloaked, No Mask)", ModAPI.LoadSprite("sprites/Zane/zaneLegacyHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zaneHunted.png"), ModAPI.LoadTexture("sprites/Zane/zaneHuntedArm.png"), new string[] { "UpperArmFront", "LowerArmFront" }, true, "Hunted", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zaneHuntedMaskless.png"), ModAPI.LoadTexture("sprites/Zane/zaneHuntedArm.png"), new string[] { "UpperArmFront", "LowerArmFront" }, true, "Hunted (No Mask)", ModAPI.LoadSprite("sprites/Zane/zaneTitaniumLegacyHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zaneLegacy.png"), true, "Legacy", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zaneLegacyMaskless.png"), true, "Legacy (No Mask)", ModAPI.LoadSprite("sprites/Zane/zaneTitaniumLegacyHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zaneLegacyCloak.png"), true, "Legacy (Cloaked)", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Zane/zaneLegacyCloakMaskless.png"), true, "Legacy (Cloaked, No Mask)", ModAPI.LoadSprite("sprites/Zane/zaneLegacyHair.png"));
                    }

                    Instance.transform.localScale = Vector2.one * UnityEngine.Random.Range(1.59f, 2f) / 2f / 0.82397f;

                    Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin);
                }
            });

            //Lloyd
            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Human"),
                NameOverride = "Lloyd" + ModTag,
                DescriptionOverride = "The green ninja.",
                CategoryOverride = ModAPI.FindCategory("Ninjago"),
                NameToOrderByOverride = "5",
                ThumbnailOverride = ModAPI.LoadSprite("sprites/Thumbnails/lloydThumbnail.png"), 
                AfterSpawn = (Instance) =>
                {
                    var skin = ModAPI.LoadTexture("sprites/Lloyd/lloydZX.png");
                    Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin);

                    var head = Instance.transform.GetChild(5);
                    var childObject = new GameObject("Hair");
                    childObject.transform.SetParent(head);
                    childObject.transform.localPosition = new Vector3(0, -0.0275f);
                    childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    childObject.transform.localScale = new Vector3(1f, 1f);
                    var childSprite = childObject.AddComponent<SpriteRenderer>();
                    childSprite.sprite = ModAPI.LoadSprite("sprites/empty.png");
                    childSprite.sortingLayerName = "Top";

                    var person = Instance.GetComponent<PersonBehaviour>();
                    foreach (var body in person.Limbs)
                    {
                        body.DiscomfortingHeatTemperature = float.MaxValue;
                        body.PhysicalBehaviour.BurningProgressionMultiplier = 0;
                        body.gameObject.AddComponent<CycleSkinTextures>();
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Lloyd/lloydZX.png"), true, "ZX", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Lloyd/lloydZXMaskless.png"), true, "ZX (Mask Off)", ModAPI.LoadSprite("sprites/Lloyd/lloydHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Lloyd/lloydElemental.png"), true, "Elemental", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Lloyd/lloydElementalMaskless.png"), true, "Elemental (Mask Off)", ModAPI.LoadSprite("sprites/Lloyd/lloydHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Lloyd/lloydGolden.png"), true, "Ultimate Spinjitzu Master", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Lloyd/lloydGoldenMaskless.png"), true, "Ultimate Spinjitzu Master (Mask Off)", ModAPI.LoadSprite("sprites/Lloyd/lloydHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Lloyd/lloydTechno.png"), true, "Techno", ModAPI.LoadSprite("sprites/Lloyd/lloydHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Lloyd/lloydTechnoMaskless.png"), true, "Techno (No Mask)", ModAPI.LoadSprite("sprites/Lloyd/lloydHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Lloyd/lloydStoneArmor.png"), true, "Stone Armor", ModAPI.LoadSprite("sprites/Lloyd/lloydHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Lloyd/lloydStoneArmorMaskless.png"), true, "Stone Armor (No Mask)", ModAPI.LoadSprite("sprites/Lloyd/lloydHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Lloyd/lloydTournament.png"), true, "Tournament", ModAPI.LoadSprite("sprites/Lloyd/lloydHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Lloyd/lloydTournamentMaskless.png"), true, "Tournament (No Mask)", ModAPI.LoadSprite("sprites/Lloyd/lloydHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Lloyd/lloydJungle.png"), true, "Jungle", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Lloyd/lloydJungleMaskless.png"), true, "Jungle (No Mask)", ModAPI.LoadSprite("sprites/Lloyd/lloydHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Lloyd/lloydDeepstone.png"), true, "Deepstone", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Lloyd/lloydDeepstoneMaskless.png"), true, "Deepstone (No Mask)", ModAPI.LoadSprite("sprites/Lloyd/lloydHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Lloyd/lloydDestiny.png"), true, "Destiny", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Lloyd/lloydDestinyMaskless.png"), true, "Destiny (No Mask)", ModAPI.LoadSprite("sprites/Lloyd/lloydHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Lloyd/lloydHonor.png"), true, "Honor", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Lloyd/lloydHonorMaskless.png"), true, "Honor (No Mask)", ModAPI.LoadSprite("sprites/Lloyd/lloydHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Lloyd/lloydFusion.png"), true, "Fusion", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Lloyd/lloydFusionMaskless.png"), true, "Fusion (No Mask)", ModAPI.LoadSprite("sprites/Lloyd/lloydHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Lloyd/lloydResistance.png"), true, "Resistance", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Lloyd/lloydResistanceMaskless.png"), true, "Resistance (No Mask)", ModAPI.LoadSprite("sprites/Lloyd/lloydLegacyHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Lloyd/lloydHunted.png"), true, "Hunted", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Lloyd/lloydHuntedMaskless.png"), true, "Hunted (No Mask)", ModAPI.LoadSprite("sprites/Lloyd/lloydLegacyHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Lloyd/lloydLegacy.png"), true, "Legacy", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Lloyd/lloydLegacyMaskless.png"), true, "Legacy (No Mask)", ModAPI.LoadSprite("sprites/Lloyd/lloydLegacyHair.png"));

                        if (body.gameObject.name.Contains("LowerArm"))
                        {
                            //body.gameObject.AddComponent<ContinuousLaser>();
                        }
                    }
                }
            });

            //Nya
            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Human"),
                NameOverride = "Nya" + ModTag,
                DescriptionOverride = "Kai's sister.",
                CategoryOverride = ModAPI.FindCategory("Ninjago"),
                NameToOrderByOverride = "6",
                ThumbnailOverride = ModAPI.LoadSprite("sprites/Thumbnails/nyaThumbnail.png"),
                AfterSpawn = (Instance) =>
                {
                    var skin = ModAPI.LoadTexture("sprites/Nya/nya.png");
                    Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin);

                    var head = Instance.transform.GetChild(5);
                    var childObject = new GameObject("Hair");
                    childObject.transform.SetParent(head);
                    childObject.transform.localPosition = new Vector3(0, -0.0275f);
                    childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    childObject.transform.localScale = new Vector3(1f, 1f);
                    var childSprite = childObject.AddComponent<SpriteRenderer>();
                    childSprite.sprite = ModAPI.LoadSprite("sprites/Nya/nyaHair.png");
                    childSprite.sortingLayerName = "Top";

                    var person = Instance.GetComponent<PersonBehaviour>();
                    foreach (var body in person.Limbs)
                    {
                        body.gameObject.AddComponent<CycleSkinTextures>();
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Nya/nya.png"), true, "Nya", ModAPI.LoadSprite("sprites/Nya/nyaHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Nya/samuraiX.png"), true, "Samurai X", ModAPI.LoadSprite("sprites/Nya/samuraiXHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Nya/samuraiX.png"), true, "Samurai X (No Helmet)", ModAPI.LoadSprite("sprites/Nya/nyaHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Nya/nyaDeepstone.png"), true, "Deepstone", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Nya/nyaDeepstoneMaskless.png"), true, "Deepstone (No Mask)", ModAPI.LoadSprite("sprites/Nya/nyaHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Nya/nyaDestiny.png"), true, "Destiny", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Nya/nyaDestinyMaskless.png"), true, "Destiny (No Mask)", ModAPI.LoadSprite("sprites/Nya/nyaHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Nya/nyaHonor.png"), true, "Honor", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Nya/nyaHonorMaskless.png"), true, "Honor (No Mask)", ModAPI.LoadSprite("sprites/Nya/nyaHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Nya/nyaFusion.png"), true, "Fusion", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Nya/nyaFusionMaskless.png"), true, "Fusion (No Mask)", ModAPI.LoadSprite("sprites/Nya/nyaHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Nya/nyaResistance.png"), true, "Resistance", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Nya/nyaResistanceMaskless.png"), true, "Resistance (No Mask)", ModAPI.LoadSprite("sprites/Nya/nyaLegacyHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Nya/nyaHunted.png"), true, "Hunted", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Nya/nyaHuntedMaskless.png"), true, "Hunted (No Mask)", ModAPI.LoadSprite("sprites/Nya/nyaLegacyHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Nya/nyaLegacy.png"), true, "Legacy", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Nya/nyaLegacyMaskless.png"), true, "Legacy (No Mask)", ModAPI.LoadSprite("sprites/Nya/nyaLegacyHair.png"));
                    }
                }
            });

            //Wu
            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Human"),
                NameOverride = "Sensei Wu" + ModTag,
                DescriptionOverride = "Master of creation.",
                CategoryOverride = ModAPI.FindCategory("Ninjago"),
                NameToOrderByOverride = "7",
                ThumbnailOverride = ModAPI.LoadSprite("sprites/Thumbnails/wuThumbnail.png"),
                AfterSpawn = (Instance) =>
                {
                    var skin = ModAPI.LoadTexture("sprites/Wu/wu.png");
                    Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin);

                    var head = Instance.transform.GetChild(5);
                    var childObject = new GameObject("Hair");
                    childObject.transform.SetParent(head);
                    childObject.transform.localPosition = new Vector3(0, -0.0275f);
                    childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    childObject.transform.localScale = new Vector3(1f, 1f);
                    var childSprite = childObject.AddComponent<SpriteRenderer>();
                    childSprite.sprite = ModAPI.LoadSprite("sprites/Wu/wuHair.png");
                    childSprite.sortingLayerName = "Top";

                    var person = Instance.GetComponent<PersonBehaviour>();
                    foreach (var body in person.Limbs)
                    {
                        body.gameObject.AddComponent<CycleSkinTextures>();
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Wu/wu.png"), true, "White gi", ModAPI.LoadSprite("sprites/Wu/wuHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Wu/wuBlack.png"), true, "Black gi", ModAPI.LoadSprite("sprites/Wu/wuHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Wu/wuTechno.png"), true, "Techno", ModAPI.LoadSprite("sprites/Wu/wuTechnoHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Wu/wuTemple.png"), true, "Temple", ModAPI.LoadSprite("sprites/Wu/wuGoldenHat.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Wu/wuBattle.png"), true, "Battle", ModAPI.LoadSprite("sprites/Wu/wuGoldenHat.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Wu/wuTeen.png"), true, "Teen", ModAPI.LoadSprite("sprites/Wu/teenWuHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Wu/wuBlack.png"), true, "Young Wu", ModAPI.LoadSprite("sprites/Wu/youngWuHair.png"));
                    }
                }
            });

            //Garmadon
            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Human"),
                NameOverride = "Lord Garmadon" + ModTag,
                DescriptionOverride = "Master of destruction.",
                CategoryOverride = ModAPI.FindCategory("Ninjago"),
                NameToOrderByOverride = "8",
                ThumbnailOverride = ModAPI.LoadSprite("sprites/Thumbnails/garmadonThumbnail.png"),
                AfterSpawn = (Instance) =>
                {
                    var skin = ModAPI.LoadTexture("sprites/Garmadon/garmadon.png");
                    Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin);

                    var head = Instance.transform.GetChild(5);
                    var childObject = new GameObject("Hair");
                    childObject.transform.SetParent(head);
                    childObject.transform.localPosition = new Vector3(0, -0.0275f);
                    childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    childObject.transform.localScale = new Vector3(1f, 1f);
                    var childSprite = childObject.AddComponent<SpriteRenderer>();
                    childSprite.sprite = ModAPI.LoadSprite("sprites/Garmadon/garmadonHair.png");
                    childSprite.sortingLayerName = "Top";

                    var person = Instance.GetComponent<PersonBehaviour>();
                    foreach (var body in person.Limbs)
                    {
                        body.gameObject.AddComponent<CycleSkinTextures>();
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Garmadon/garmadon.png"), true, "Corrupted", ModAPI.LoadSprite("sprites/Garmadon/garmadonHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Garmadon/garmadonSensei.png"), true, "Sensei", ModAPI.LoadSprite("sprites/Garmadon/garmadonSenseiHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Garmadon/youngGarmadon.png"), true, "Young Garmadon", ModAPI.LoadSprite("sprites/Garmadon/youngGarmadonHair.png"));
                    }
                }
            });

            //P.I.X.A.L.
            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Android"),
                NameOverride = "P.I.X.A.L." + ModTag,
                DescriptionOverride = "Primary Interactive eX-ternal Assistant Life-form",
                CategoryOverride = ModAPI.FindCategory("Ninjago"),
                NameToOrderByOverride = "9",
                ThumbnailOverride = ModAPI.LoadSprite("sprites/Thumbnails/pixalThumbnail.png"),
                AfterSpawn = (Instance) =>
                {
                    var skin = ModAPI.LoadTexture("sprites/Pixal/pixal.png");

                    var head = Instance.transform.GetChild(0);
                    var childObject = new GameObject("Hair");
                    childObject.transform.SetParent(head);
                    childObject.transform.localPosition = new Vector3(0, -0.0275f);
                    childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    childObject.transform.localScale = new Vector3(1f, 1f);
                    var childSprite = childObject.AddComponent<SpriteRenderer>();
                    childSprite.sprite = ModAPI.LoadSprite("sprites/Pixal/pixalHair.png");
                    childSprite.sortingLayerName = "Top";

                    var person = Instance.GetComponent<PersonBehaviour>();
                    person.RandomisedSize = true;

                    foreach (var body in person.Limbs)
                    {
                        if (body.gameObject.name == "UpperArmFront")
                        {
                            OtherStuff.SetBodyPartTexture(body, ModAPI.LoadTexture("sprites/Pixal/pixalArm.png"));
                        }
                        else if (body.gameObject.name == "LowerArmFront")
                        {
                            OtherStuff.SetBodyPartTexture(body, ModAPI.LoadTexture("sprites/Pixal/pixalArm.png"));
                        }

                        body.gameObject.AddComponent<CycleSkinTextures>();
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Pixal/pixal.png"), ModAPI.LoadTexture("sprites/Pixal/pixalArm.png"), new string[] { "UpperArmFront", "LowerArmFront" }, true, "P.I.X.A.L.", ModAPI.LoadSprite("sprites/Pixal/pixalHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Pixal/samuraiX.png"), true, "Samurai X", ModAPI.LoadSprite("sprites/Pixal/samuraiXHelmet.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Pixal/samuraiX.png"), true, "Samurai X (No Helmet)", ModAPI.LoadSprite("sprites/Pixal/pixalHair.png"));
                    }

                    Instance.transform.localScale = Vector2.one * UnityEngine.Random.Range(1.59f, 2f) / 2f / 0.82397f;

                    Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin);
                }
            });

            //Skylor
            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Human"),
                NameOverride = "Skylor" + ModTag,
                DescriptionOverride = "Master of amber.",
                CategoryOverride = ModAPI.FindCategory("Ninjago"),
                NameToOrderByOverride = "9-0",
                ThumbnailOverride = ModAPI.LoadSprite("sprites/Thumbnails/skylorThumbnail.png"),
                AfterSpawn = (Instance) =>
                {
                    var skin = ModAPI.LoadTexture("sprites/Skylor/skylorJungleMaskless.png");
                    Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin);

                    var head = Instance.transform.GetChild(5);
                    var childObject = new GameObject("Hair");
                    childObject.transform.SetParent(head);
                    childObject.transform.localPosition = new Vector3(0, -0.0275f);
                    childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    childObject.transform.localScale = new Vector3(1f, 1f);
                    var childSprite = childObject.AddComponent<SpriteRenderer>();
                    childSprite.sprite = ModAPI.LoadSprite("sprites/Skylor/skylorHair.png");
                    childSprite.sortingLayerName = "Top";

                    var person = Instance.GetComponent<PersonBehaviour>();
                    foreach (var body in person.Limbs)
                    {
                        body.gameObject.AddComponent<CycleSkinTextures>();
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Skylor/skylorJungle.png"), true, "Jungle", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Skylor/skylorJungleMaskless.png"), true, "Jungle (No Mask)", ModAPI.LoadSprite("sprites/Skylor/skylorHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Skylor/skylorJungleMaskless.png"), true, "Jungle (Hood)", ModAPI.LoadSprite("sprites/Skylor/skylorJungleHood.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Skylor/skylorDestiny.png"), true, "Destiny", ModAPI.LoadSprite("sprites/Skylor/skylorHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Skylor/skylorDestiny.png"), true, "Destiny (Hood)", ModAPI.LoadSprite("sprites/Skylor/skylorHood.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Skylor/skylorHunted.png"), true, "Hunted", ModAPI.LoadSprite("sprites/Skylor/skylorHair.png"));
                    }
                }
            });

            //Ronin
            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Human"),
                NameOverride = "Ronin" + ModTag,
                DescriptionOverride = "In life, there's always second chances.",
                CategoryOverride = ModAPI.FindCategory("Ninjago"),
                NameToOrderByOverride = "9-1",
                ThumbnailOverride = ModAPI.LoadSprite("sprites/Thumbnails/roninThumbnail.png"),
                AfterSpawn = (Instance) =>
                {
                    var skin = ModAPI.LoadTexture("sprites/Characters/ronin.png");
                    Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin);

                    var head = Instance.transform.GetChild(5);
                    var childObject = new GameObject("Hair");
                    childObject.transform.SetParent(head);
                    childObject.transform.localPosition = new Vector3(0, -0.0275f);
                    childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    childObject.transform.localScale = new Vector3(1f, 1f);
                    var childSprite = childObject.AddComponent<SpriteRenderer>();
                    childSprite.sprite = ModAPI.LoadSprite("sprites/Characters/roninHat.png");
                    childSprite.sortingLayerName = "Top";

                    var person = Instance.GetComponent<PersonBehaviour>();
                    foreach (var body in person.Limbs)
                    {
                        if (body.gameObject.name == "UpperArmFront")
                        {
                            OtherStuff.SetBodyPartTexture(body, ModAPI.LoadTexture("sprites/Characters/roninArm.png"));
                        }
                        else if (body.gameObject.name == "LowerArmFront")
                        {
                            OtherStuff.SetBodyPartTexture(body, ModAPI.LoadTexture("sprites/Characters/roninArm.png"));
                        }

                        body.gameObject.AddComponent<CycleSkinTextures>();
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Characters/ronin.png"), ModAPI.LoadTexture("sprites/Characters/roninArm.png"), new string[] { "UpperArmFront", "LowerArmFront" }, true, "Mask On", ModAPI.LoadSprite("sprites/Characters/roninHat.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Characters/roninMaskless.png"), ModAPI.LoadTexture("sprites/Characters/roninArm.png"), new string[] { "UpperArmFront", "LowerArmFront" }, true, "Mask Off", ModAPI.LoadSprite("sprites/Characters/roninHair.png"));
                    }
                }
            });

            //The Overlord
            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Human"),
                NameOverride = "The Overlord" + ModTag,
                DescriptionOverride = "The Golden Master.",
                CategoryOverride = ModAPI.FindCategory("Ninjago"),
                NameToOrderByOverride = "ZZZZZZZZZZZZZZZZZY",
                ThumbnailOverride = ModAPI.LoadSprite("sprites/Thumbnails/overlordThumbnail.png"),
                AfterSpawn = (Instance) =>
                {
                    var skin = ModAPI.LoadTexture("sprites/Characters/overlord.png");
                    Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin);

                    var head = Instance.transform.GetChild(5);
                    var childObject = new GameObject("Hair");
                    childObject.transform.SetParent(head);
                    childObject.transform.localPosition = new Vector3(0, -0.0275f);
                    childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    childObject.transform.localScale = new Vector3(1f, 1f);
                    var childSprite = childObject.AddComponent<SpriteRenderer>();
                    childSprite.sprite = ModAPI.LoadSprite("sprites/Characters/overlordHair.png");
                    childSprite.sortingLayerName = "Top";
                    Instance.transform.localScale = Vector2.one * UnityEngine.Random.Range(2.59f, 3f) / 2f / 0.82397f;
                }
            });

            //Dareth
            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Human"),
                NameOverride = "Dareth" + ModTag,
                DescriptionOverride = "The BROWN ninja!",
                CategoryOverride = ModAPI.FindCategory("Ninjago"),
                NameToOrderByOverride = "ZZZZZZZZZZZZZZZZZZ",
                ThumbnailOverride = ModAPI.LoadSprite("sprites/Thumbnails/darethThumbnail.png"),
                AfterSpawn = (Instance) =>
                {
                    var skin = ModAPI.LoadTexture("sprites/Characters/dareth.png");
                    Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin);

                    var head = Instance.transform.GetChild(5);
                    var childObject = new GameObject("Hair");
                    childObject.transform.SetParent(head);
                    childObject.transform.localPosition = new Vector3(0, -0.0275f);
                    childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    childObject.transform.localScale = new Vector3(1f, 1f);
                    var childSprite = childObject.AddComponent<SpriteRenderer>();
                    childSprite.sprite = ModAPI.LoadSprite("sprites/Characters/darethHair.png");
                    childSprite.sortingLayerName = "Top";

                    var person = Instance.GetComponent<PersonBehaviour>();
                    foreach (var body in person.Limbs)
                    {
                        body.gameObject.AddComponent<CycleSkinTextures>();
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Characters/dareth.png"), true, "Mask Off", ModAPI.LoadSprite("sprites/Characters/darethHair.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Characters/darethMasked.png"), true, "Mask On", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/Characters/darethHunted.png"), true, "Mask On (Hunted)", ModAPI.LoadSprite("sprites/empty.png"));
                    }
                }
            });

            #endregion
        }
    }
    public class CycleSkinTextures : MonoBehaviour
    {
        public class Skin
        {
            public Texture2D SkinTexture, FleshTexture, BoneTexture;
            public string Description;
            public Texture2D secondTexture;
            public string[] SecondTextureLimbs;
            public bool includesHair;
            public bool glow;
            public Sprite hair;
        }
        public List<Skin> Textures = new List<Skin>();
        int CurrentIndex = 0;
        public PersonBehaviour person;
        public bool CanSwitch = true;
        GameObject SelectedSkin;
        ContextMenuButton menuButton;
        public void Start()
        {
            if (GetComponent<LimbBehaviour>() && !person)
                person = GetComponent<LimbBehaviour>().Person;
            GetComponent<PhysicalBehaviour>().ContextMenuOptions.Buttons.Add(menuButton = new ContextMenuButton("ChangeSkin", "Change Skin", "Change Skin", new UnityAction[1]
            {
                () =>
                {
                    GameObject Canvas = OtherStuff.CreateCanvas();
        if (Canvas)
        {
            GameObject panel = new GameObject("Panel");
            panel.AddComponent<CanvasRenderer>();
            Image i = panel.AddComponent<Image>();
            i.color = new Color(0, 0, 0, 0.8f);
            panel.transform.SetParent(Canvas.transform, false);
            panel.transform.localScale *= 7;
            GameObject Button = new GameObject();
            Button.AddComponent<CanvasRenderer>();
            Image B1I = Button.AddComponent<Image>();
            Button.AddComponent<Button>();
            B1I.color = new Color(0, 0, 0, 0.8f);
            Button.transform.SetParent(panel.transform, false);
            Button.GetComponent<RectTransform>().sizeDelta = new Vector2(36.44165f, 8.680367f);
            Button.GetComponent<RectTransform>().localPosition = new Vector3(-20.9f, -43.5f, 0);
            Button.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
            Button.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
            Button.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0.5f);
            Button.AddComponent<Button>();
            GameObject ButtonText = new GameObject();
            ButtonText.AddComponent<TextMeshProUGUI>().text = "Confirm";
            ButtonText.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Center;
            ButtonText.GetComponent<TextMeshProUGUI>().fontSize = 6.7f;
            ButtonText.GetComponent<RectTransform>().sizeDelta = Button.GetComponent<RectTransform>().sizeDelta;
            ButtonText.transform.SetParent(Button.transform, false);
            GameObject Button2 = new GameObject();
            Button2.AddComponent<CanvasRenderer>();
            Image B2I = Button2.AddComponent<Image>();
            Button2.AddComponent<Button>();
            B2I.color = new Color(0, 0, 0, 0.8f);
            Button2.transform.SetParent(panel.transform, false);
            Button2.GetComponent<RectTransform>().sizeDelta = new Vector2(36.44165f, 8.680367f);
            Button2.GetComponent<RectTransform>().localPosition = new Vector3(20.9f, -43.5f, 0);
            Button2.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
            Button2.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
            Button2.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0.5f);
            Button2.AddComponent<Button>();
            GameObject Button2Text = new GameObject();
            Button2Text.AddComponent<TextMeshProUGUI>().text = "Cancel";
            Button2Text.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Center;
            Button2Text.GetComponent<TextMeshProUGUI>().fontSize = 6.7f;
            Button2Text.GetComponent<RectTransform>().sizeDelta = Button2.GetComponent<RectTransform>().sizeDelta;
            Button2Text.transform.SetParent(Button2.transform, false);
            GameObject Title = new GameObject();
            Title.AddComponent<TextMeshProUGUI>().text = "Skin/Costume Selector";
            Title.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Center;
            Title.GetComponent<TextMeshProUGUI>().fontSize = 4.88f;
            Title.GetComponent<RectTransform>().sizeDelta = new Vector2(99.99997f, 12.39016f);
            Title.transform.SetParent(panel.transform, false);
            Title.GetComponent<RectTransform>().localPosition = new Vector3(0, 43.805f, 0);
            GameObject Description = new GameObject();
            Description.AddComponent<TextMeshProUGUI>().text = "";
            Description.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Center;
            Description.GetComponent<TextMeshProUGUI>().fontSize = 3.13f;
            Description.GetComponent<RectTransform>().sizeDelta = new Vector2(93.73767f, 7.775314f);
            Description.transform.SetParent(panel.transform, false);
            Description.GetComponent<RectTransform>().localPosition = new Vector3(0, -34.7f, 0);
            GameObject AppViewPort = new GameObject("SkinList");
            AppViewPort.AddComponent<CanvasRenderer>();
            Image i5 = AppViewPort.AddComponent<Image>();
            i5.color = new Color(0, 0, 0, 0.3f);
            AppViewPort.AddComponent<Mask>().showMaskGraphic = true;
            AppViewPort.transform.SetParent(Canvas.transform, false);
            AppViewPort.GetComponent<RectTransform>().sizeDelta = new Vector2(638.9575f, 456.4362f);
            AppViewPort.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 45.44891f);
            GameObject SkinList = new GameObject("SkinList");
            SkinList.AddComponent<CanvasRenderer>();
            SkinList.transform.SetParent(AppViewPort.transform, false);
            SkinList.transform.localScale *= 5;
            SkinList.transform.localScale += new Vector3(1.4f, 0, 0);
            SkinList.transform.position += new Vector3(0, 35, 0);
            SkinList.AddComponent<GridLayoutGroup>();
            SkinList.GetComponent<GridLayoutGroup>().padding.top = 3;
            SkinList.GetComponent<GridLayoutGroup>().padding.left = 3;
            SkinList.GetComponent<GridLayoutGroup>().padding.right = 3;
            SkinList.GetComponent<GridLayoutGroup>().cellSize = new Vector2(9, 45);
            SkinList.GetComponent<GridLayoutGroup>().spacing = new Vector2(1.5f, 1.8f);
            SkinList.AddComponent<ContentSizeFitter>().verticalFit = ContentSizeFitter.FitMode.PreferredSize;

            Button.GetComponent<Button>().onClick.AddListener(Select);
            void Select()
            {
                if (SelectedSkin)
                {
                    person.SetBodyTextures(Textures[SelectedSkin.transform.GetSiblingIndex()].SkinTexture, Textures[SelectedSkin.transform.GetSiblingIndex()].FleshTexture, Textures[SelectedSkin.transform.GetSiblingIndex()].BoneTexture);
                    if (Textures[SelectedSkin.transform.GetSiblingIndex()].includesHair)
                    {
                        person.transform.GetChild(person.Limbs[0].SpeciesIdentity == "Android" ? 0 : 5).GetChild(0).GetComponent<SpriteRenderer>().sprite = Textures[SelectedSkin.transform.GetSiblingIndex()].hair;
                    }
                    if (Textures[SelectedSkin.transform.GetSiblingIndex()].secondTexture)
                    {

                        foreach (var body in person.Limbs)
                        {
                            foreach (var item in Textures[SelectedSkin.transform.GetSiblingIndex()].SecondTextureLimbs)
                            {
                                if (body.gameObject.name == item)
                                {
                                    OtherStuff.SetBodyPartTexture(body, Textures[SelectedSkin.transform.GetSiblingIndex()].secondTexture);
                                }
                            }
                        }
                    }
                    Destroy(panel.gameObject);
                    Destroy(SkinList);
                    Destroy(Canvas.gameObject);
                    GameObject.FindObjectOfType<Global>().RemoveUiBlocker();
                }
            }

            Button2.GetComponent<Button>().onClick.AddListener(Cancel);
            void Cancel()
            {
                Destroy(panel.gameObject);
                Destroy(SkinList);
                Destroy(Canvas.gameObject);
                GameObject.FindObjectOfType<Global>().RemoveUiBlocker();
            }

            GameObject Scrollbar = UiCreatingStuff.CreateScrollBar(panel, new Vector2(52.8f, 0.1f));
            Scrollbar.transform.localScale = Scrollbar.transform.localScale * 0.22515f;
            Scrollbar.GetComponent<Scrollbar>().SetDirection(UnityEngine.UI.Scrollbar.Direction.BottomToTop, true);

            SkinList.AddComponent<ScrollRect>();
            SkinList.GetComponent<ScrollRect>().viewport = AppViewPort.GetComponent<RectTransform>();
            SkinList.GetComponent<ScrollRect>().content = SkinList.GetComponent<RectTransform>();
            SkinList.GetComponent<ScrollRect>().scrollSensitivity = 22;

            SkinList.GetComponent<ScrollRect>().horizontal = false;
            SkinList.GetComponent<ScrollRect>().verticalScrollbar = Scrollbar.GetComponent<Scrollbar>();
            SkinList.GetComponent<ScrollRect>().verticalScrollbarSpacing = -3f;

            foreach (var item in Textures)
            {


                GameObject NewSkin = new GameObject("NewSkin");
                NewSkin.AddComponent<CanvasRenderer>();
                Image i3 = NewSkin.AddComponent<Image>();
                i3.color = new Color(0, 0, 0, 0.8f);
                Button SkinButton = NewSkin.AddComponent<Button>();
                SkinButton.GetComponent<Button>().onClick.AddListener(SelectSkin);
                void SelectSkin()
                {
                    if (SelectedSkin)
                        SelectedSkin.GetComponent<Image>().color = new Color(0, 0, 0, 0.4f);
                    SelectedSkin = NewSkin;
                    Description.GetComponent<TextMeshProUGUI>().text = Textures[SelectedSkin.transform.GetSiblingIndex()].Description;
                    SelectedSkin.GetComponent<Image>().color = new Color(1, 1, 1, 0.4f);
                }

                NewSkin.transform.SetParent(SkinList.transform, false);
                GameObject SkinSprite = Instantiate(NewSkin.gameObject, NewSkin.transform);

                Rect rec = new Rect(0, 0, item.SkinTexture.width, item.SkinTexture.height);


                SkinSprite.GetComponent<Image>().sprite = Sprite.Create(item.SkinTexture, rec, new Vector2(0, 0), .01f);
                SkinSprite.GetComponent<Image>().raycastTarget = false;
                SkinSprite.GetComponent<Image>().color = Color.white;
                NewSkin.AddComponent<GridLayoutGroup>().cellSize = new Vector2(9, 45);

            }





        }
                }
                 }));
        }

        public void AddNewTexture(Texture2D texture, string Description = null, Texture2D secondTexture = null, string[] SecondTextureLimbs = null)
        {
            Skin NewSkin = new Skin();
            NewSkin.SkinTexture = texture;
            if (Description != null)
                NewSkin.Description = Description;
            if (secondTexture)
                NewSkin.secondTexture = secondTexture;
            if (SecondTextureLimbs != null)
                NewSkin.SecondTextureLimbs = SecondTextureLimbs;
            Textures.Add(NewSkin);
        }

        public void AddNewTexture(Texture2D texture, bool hasHair, string Description = null, Sprite hair = null, Texture2D flesh = null, Texture2D bone = null)
        {
            Skin NewSkin = new Skin();
            NewSkin.SkinTexture = texture;
            NewSkin.FleshTexture = flesh;
            NewSkin.BoneTexture = bone;
            if (Description != null)
                NewSkin.Description = Description;
            NewSkin.includesHair = hasHair;
            if (hair != null)
                NewSkin.hair = hair;
            Textures.Add(NewSkin);
        }

        public void AddNewTexture(Texture2D texture, Texture2D secondTexture, string[] SecondTextureLimbs, bool hasHair, string Description = null, Sprite hair = null)
        {
            Skin NewSkin = new Skin();
            NewSkin.SkinTexture = texture;
            if (Description != null)
                NewSkin.Description = Description;
            if (secondTexture)
                NewSkin.secondTexture = secondTexture;
            if (SecondTextureLimbs != null)
                NewSkin.SecondTextureLimbs = SecondTextureLimbs;
            NewSkin.includesHair = hasHair;
            if (hair != null)
                NewSkin.hair = hair;
            Textures.Add(NewSkin);
        }
    }

    public class OtherStuff : MonoBehaviour
    {
        public static void SetBodyPartTexture(LimbBehaviour body, Texture2D Skin, Texture2D Flesh = null)
        {
            float scale = 1f;
            SpriteRenderer renderer = body.SkinMaterialHandler.renderer;
            Sprite sprite1 = renderer.sprite;
            Sprite sprite2 = generateFor(Skin, sprite1);
            renderer.sprite = sprite2;
            if (Flesh)
                renderer.material.SetTexture("_FleshTex", Flesh);



            Sprite generateFor(Texture2D t, Sprite original)
            {
                Texture2D texture = t;
                Rect rect1 = original.rect;
                Vector2 position = rect1.position * scale;
                rect1 = original.rect;
                Vector2 size = rect1.size * scale;
                Rect rect2 = new Rect(position, size);
                Vector2 pivot = new Vector2(0.5f, 0.5f);
                double num = original.pixelsPerUnit * (double)scale;
                Vector4 border = original.border * scale;
                return Sprite.Create(texture, rect2, pivot, (float)num, 0U, SpriteMeshType.FullRect, border, false);

            }
        }

        public static void RemakeBodyPartNew(LimbBehaviour body, string Path)
        {
            string PartName = body.gameObject.name;
            if (PartName.Contains("Front"))
            {
                PartName = PartName.Remove(PartName.LastIndexOf("Front"), 5);
            }


            body.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite($"{Path}{PartName}.png");
            body.GetComponent<SpriteRenderer>().material.SetTexture("_FleshTex", ModAPI.LoadTexture($"{Path}{PartName} F.png"));
            body.GetComponent<SpriteRenderer>().material.SetTexture("_BoneTex", ModAPI.LoadTexture($"{Path}{PartName} B.png"));
        }

        public static GameObject CreateCanvas(bool AddUiBlocker = true, bool AddGreyBgg = true)
        {
            if (!FindObjectOfType<CanvasTag>())
            {
                if (AddUiBlocker)
                    GameObject.FindObjectOfType<Global>().AddUiBlocker();
                GameObject Canvas = new GameObject();
                GameObject GreyBg;
                if (AddGreyBgg)
                {
                    GreyBg = UiCreatingStuff.CreatePanel(Canvas, new Vector2(55500, 55500), Vector2.zero, 0.7f);
                    GreyBg.GetComponent<Image>().color = new Color(0.2075472f, 0.2075472f, 0.2075472f, 0.5450981f);
                    Canvas.AddComponent<CanvasTag>().Bg = GreyBg;
                }
                Canvas.AddComponent<Canvas>();
                Canvas.AddComponent<CanvasScaler>();
                Canvas.AddComponent<GraphicRaycaster>();
                Canvas.GetComponent<Canvas>().renderMode = RenderMode.ScreenSpaceOverlay;
                Canvas.GetComponent<Canvas>().sortingOrder = -2;
                Canvas.GetComponent<CanvasScaler>().uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
                Canvas.GetComponent<CanvasScaler>().referenceResolution = new Vector2(1920, 1080);
                Canvas.GetComponent<CanvasScaler>().screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
                Canvas.GetComponent<CanvasScaler>().matchWidthOrHeight = 0.763f;
                return Canvas;
            }
            else return null;
        }

        public class CanvasTag : MonoBehaviour
        {
            public GameObject Bg;

            public void OnDestroy()
            {
                if (FindObjectOfType<Global>().ActiveUiBlockers > 0)
                    FindObjectOfType<Global>().RemoveUiBlocker();

                if (Bg)
                    Destroy(Bg);
            }
        }
    }

    public class UiCreatingStuff : MonoBehaviour
    {
        public static GameObject CreateButton(GameObject ParentOrCanvas, string ButtonText, Vector3 Position, Vector2 SizeDelta, float TextSize = 6.7f)
        {
            if (SizeDelta == Vector2.zero) SizeDelta = new Vector2(36.44165f, 8.680367f);
            GameObject Button = new GameObject();
            Button.AddComponent<CanvasRenderer>();
            Image B1I = Button.AddComponent<Image>();
            Button.AddComponent<Button>();
            B1I.color = new Color(0, 0, 0, 0.8f);
            Button.transform.SetParent(ParentOrCanvas.transform, false);
            Button.GetComponent<RectTransform>().sizeDelta = SizeDelta;
            Button.GetComponent<RectTransform>().localPosition = Position;
            Button.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
            Button.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
            Button.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0.5f);
            Button.AddComponent<AudioSource>();
            GameObject ButtonTextObject = new GameObject();
            ButtonTextObject.AddComponent<TextMeshProUGUI>().text = ButtonText;
            ButtonTextObject.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Center;
            ButtonTextObject.GetComponent<TextMeshProUGUI>().fontSize = TextSize;
            ButtonTextObject.GetComponent<TextMeshProUGUI>().fontSizeMin = 0;
            ButtonTextObject.transform.SetParent(Button.transform, false);
            ButtonTextObject.GetComponent<RectTransform>().sizeDelta = Button.GetComponent<RectTransform>().sizeDelta;
            return Button;
        }

        public static GameObject CreateText(GameObject ParentOrCanvas, string Text, Vector3 Position, Vector2 SizeDelta, float TextSize = 5.4f)
        {
            if (SizeDelta == Vector2.zero) SizeDelta = new Vector2(99.99997f, 12.39016f);
            GameObject Title = new GameObject();
            Title.AddComponent<TextMeshProUGUI>().text = Text;
            Title.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Center;
            Title.GetComponent<TextMeshProUGUI>().fontSize = TextSize;
            Title.GetComponent<RectTransform>().sizeDelta = SizeDelta;
            Title.transform.SetParent(ParentOrCanvas.transform, false);
            Title.GetComponent<RectTransform>().localPosition = Position;
            return Title;
        }

        public static GameObject CreatePanel(GameObject ParentOrCanvas, Vector2 SizeDelta, Vector3 Postion, float Opacity = 0.4f)
        {
            GameObject Panel = new GameObject("Panel");
            Panel.AddComponent<CanvasRenderer>();
            Image AppImage = Panel.AddComponent<Image>();
            AppImage.color = new Color(0, 0, 0, Opacity);
            Panel.transform.SetParent(ParentOrCanvas.transform, false);
            Panel.GetComponent<RectTransform>().sizeDelta = SizeDelta;
            Panel.GetComponent<RectTransform>().localPosition = Postion;
            return Panel;
        }

        public static GameObject CreateScrollBar(GameObject ParentOrCanvas, Vector2 Position)
        {
            GameObject Scrollbar = CreatePanel(ParentOrCanvas, new Vector2(160f, 20f), new Vector3(0, 0, 0));
            Scrollbar.AddComponent<Scrollbar>();
            GameObject SlidingArea = new GameObject();
            SlidingArea.AddComponent<RectTransform>();
            SlidingArea.GetComponent<RectTransform>().offsetMax = new Vector2(-10, -10);
            SlidingArea.GetComponent<RectTransform>().offsetMin = new Vector2(10, 10);
            SlidingArea.GetComponent<RectTransform>().anchorMin = Vector2.zero;
            SlidingArea.GetComponent<RectTransform>().anchorMax = Vector2.one;
            SlidingArea.transform.SetParent(Scrollbar.transform, false);
            GameObject HandelBar = CreatePanel(SlidingArea, new Vector2(160f, 20f), new Vector3(0, 0, 0));
            HandelBar.GetComponent<RectTransform>().offsetMax = new Vector2(10, 10);
            HandelBar.GetComponent<RectTransform>().offsetMin = new Vector2(-10, -10);
            Scrollbar.GetComponent<Scrollbar>().handleRect = HandelBar.GetComponent<RectTransform>();
            Scrollbar.GetComponent<Scrollbar>().targetGraphic = HandelBar.GetComponent<Image>();
            Scrollbar.GetComponent<RectTransform>().localPosition = Position;
            return Scrollbar;
        }
    }

    public class ContinuousLaser : MonoBehaviour, Messages.IUseContinuous
    {
        public GameObject Laser;
        public AudioSource Auds;
        public bool CanUseAgain = true;
        public RaycastHit2D hit;
        public AudioClip LaserBeamSound;
        public Coroutine LaserCoroutine;
        public Texture2D LaserTexture;
        public Color Tint = Color.green;
        public Sprite none;
        public bool Smokey;
        public ParticleSystem smoke;

        public void Start()
        {
            Auds = new GameObject().AddComponent<AudioSource>();
            Auds.spatialBlend = 1;
            FindObjectOfType<Global>().AddAudioSource(Auds, false);
            Auds.transform.SetParent(transform, false);
            Auds.gameObject.AddComponent<AudioDistortionFilter>().distortionLevel = 0.8f;
            var smok = Instantiate(Resources.Load<GameObject>("Prefabs/SmokeParticle"), transform.position, Quaternion.identity, transform);
            smok.AddComponent<Optout>();
            smoke = smok.GetComponent<ParticleSystem>();
            var main = smoke.main;
            main.playOnAwake = false;
            main.loop = true;
            main.simulationSpace = ParticleSystemSimulationSpace.World;
            var shape = smoke.shape;
            shape.spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            var em = smoke.emission;
            em.rateOverTime = new ParticleSystem.MinMaxCurve(5f);
            em.enabled = true;
            var render = smok.GetComponent<ParticleSystemRenderer>();
            render.material.color = Tint;
            smoke.Stop();
        }

        public void UseContinuous(ActivationPropagation activation)
        {
            if (!Laser)
            {
                Laser = new GameObject();
                Laser.AddComponent<LineRenderer>().useWorldSpace = false;
                Laser.GetComponent<LineRenderer>().SetPosition(0, new Vector3(0, -0.14f, 0));
                Laser.GetComponent<LineRenderer>().SetPosition(1, new Vector3(0, -1.1f, 0));
                Laser.GetComponent<LineRenderer>().startWidth = 0.2f;
                Laser.GetComponent<LineRenderer>().endWidth = 0.25f;
                Laser.GetComponent<LineRenderer>().startColor = Tint;
                Laser.GetComponent<LineRenderer>().endColor = Tint;
                Laser.GetComponent<LineRenderer>().textureMode = LineTextureMode.Tile;
                Material material = new Material(ModAPI.FindMaterial("VeryBright"));
                material.mainTexture = LaserTexture;
                material.mainTexture.wrapMode = TextureWrapMode.Repeat;
                Laser.transform.SetParent(transform, false);
                Laser.GetComponent<LineRenderer>().material = material;
                Auds.clip = LaserBeamSound;
                Auds.loop = true;
                Auds.Play();
                if (Smokey)
                {
                    smoke.Play();
                }
            }
            hit = Physics2D.Raycast(transform.position + (-transform.up * 0.15f), -transform.up, 9999);
            Laser.GetComponent<LineRenderer>().SetPosition(1, new Vector3(0.06f, -Vector2.Distance(transform.position, hit.point), 0));
            if (CanUseAgain)
            {
                if (LaserCoroutine != null)
                {
                    StopCoroutine(LaserCoroutine);
                    LaserCoroutine = null;
                }
                LaserCoroutine = StartCoroutine(LaserShotInterval(hit));
            }
        }

        IEnumerator LaserShotInterval(RaycastHit2D hit)
        {
            CanUseAgain = false;
            BlasterboltBehaviour blasterboltPrefab = ModAPI.FindSpawnable("Blaster Rifle").Prefab.GetComponent<BlasterBehaviour>().Bolt.GetComponent<BlasterboltBehaviour>();
            if (hit.collider)
            {
                Vector2 normal = hit.normal;
                float z = Mathf.Atan2(normal.y, normal.x);
                bool flag = WaterBehaviour.IsPointUnderWater(hit.point);
                if (flag)
                {
                    ExplosionCreator.CreateUnderwaterExplosionEffect(new ExplosionCreator.ExplosionParameters()
                    {
                        Position = hit.point
                    }, false);
                }
                else
                {
                    //     Instantiate<GameObject>(blasterboltPrefab.ImpactEffect, (Vector3)hit.point, Quaternion.Euler(0.0f, 0.0f, z)).transform.up = (Vector3)normal;
                    //     Instantiate<GameObject>(blasterboltPrefab.HitDecal, (Vector3)hit.point, Quaternion.identity, hit.transform);
                }
                ExplosionCreator.CreatePulseExplosion(hit.point, blasterboltPrefab.ImpactStrength * 4, 1f, !flag && blasterboltPrefab.SpawnExplosionEffect, false);
                if (blasterboltPrefab.CreateExplosion)
                    ExplosionCreator.CreateExplosionWithWater(WaterBehaviour.IsPointUnderWater(hit.point), new ExplosionCreator.ExplosionParameters(8U, hit.point, 4f, blasterboltPrefab.ExplosionDamage * 3, false, dismember: 0.2f), false);
                PhysicalBehaviour physicalBehaviour;
                if (Global.main.PhysicalObjectsInWorldByTransform.TryGetValue(hit.transform, out physicalBehaviour) && physicalBehaviour.SimulateTemperature)
                    physicalBehaviour.Temperature = Mathf.Lerp(physicalBehaviour.Temperature, blasterboltPrefab.TemperatureTarget, 0.05f / physicalBehaviour.ObjectArea);
                hit.transform.SendMessage("Shot", new Shot(normal, hit.point, blasterboltPrefab.damage * 4), SendMessageOptions.DontRequireReceiver);
                hit.transform.SendMessage("Decal", new DecalInstruction(blasterboltPrefab.ImpactDecal, hit.point, calculateDecalSize(blasterboltPrefab.damage)), SendMessageOptions.DontRequireReceiver);

                float calculateDecalSize(float dmg) => Mathf.Max(Mathf.Pow(dmg, 3.35f) / Mathf.Pow(10f, 8f), 0.15f) * blasterboltPrefab.DecalSizeMultiplier;
            }
            yield return new WaitForSeconds(0.05f);
            CanUseAgain = true;
            yield return new WaitForSeconds(0.05f);
            Destroy(Laser);
            Auds.loop = false;
            Auds.Stop();
            if (Smokey)
            {
                smoke.Stop();
            }
        }
    }

    public class HumanTorch : MonoBehaviour, Messages.IUse
    {
        public GameObject BurnObject;
        bool isPeople = false;
        public Texture2D JohnnySkin;
        public Texture2D OgSkin;

        public void Update()
        {
            if (BurnObject)
            {
                BurnObject.transform.position = transform.position;
            }
            if (gameObject.GetComponent<LimbBehaviour>().PhysicalBehaviour.OnFire)
                gameObject.GetComponent<LimbBehaviour>().PhysicalBehaviour.Extinguish();

            if (isPeople && BurnObject)
                StartCoroutine(Relight());

        }

        public void Use(ActivationPropagation activationPropagation)
        {
            foreach (LimbBehaviour body in GetComponentInParent<PersonBehaviour>().Limbs)
            {
                body.GetComponent<HumanTorch>().Burn();
            }
        }

        public void Burn()
        {
            if (!isPeople)
            {
                gameObject.GetComponent<LimbBehaviour>().PhysicalBehaviour.burnIntensity = 0;
                gameObject.GetComponent<LimbBehaviour>().PhysicalBehaviour.Properties.Burnrate = 0.000001f;
                BurnObject = GameObject.Instantiate(ModAPI.FindSpawnable("Brick").Prefab);
                BurnObject.GetComponent<Collider2D>().enabled = false;
                BurnObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
                BurnObject.GetComponent<SpriteRenderer>().color = Color.clear;
                BurnObject.transform.position = transform.position;
                BurnObject.transform.SetParent(transform);
                BurnObject.GetComponent<PhysicalBehaviour>().burnIntensity = 35;
                BurnObject.GetComponent<PhysicalBehaviour>().Properties.Flammability = 100;
                BurnObject.GetComponent<PhysicalBehaviour>().Properties.Burnrate = 0.000001f;
                isPeople = true;
            }

            else if (isPeople)
            {
                Destroy(BurnObject);
                isPeople = false;
            }
        }

        public void OnCollisionEnter2D(Collision2D other)
        {
            if (isPeople && other.gameObject.GetComponent<LimbBehaviour>())
            {
                other.gameObject.GetComponent<LimbBehaviour>().PhysicalBehaviour.Ignite();
                other.gameObject.GetComponent<LimbBehaviour>().PhysicalBehaviour.Ignite();
                other.gameObject.GetComponent<LimbBehaviour>().PhysicalBehaviour.Ignite();
                other.gameObject.GetComponent<LimbBehaviour>().PhysicalBehaviour.Ignite();
                other.gameObject.GetComponent<LimbBehaviour>().PhysicalBehaviour.Ignite();
            }
        }

        public virtual IEnumerator Relight()
        {
            if (BurnObject)
            {
                //     BurnObject.GetComponent<PhysicalBehaviour>().Extinguish();
                //      BurnObject.GetComponent<PhysicalBehaviour>().Ignite();
                BurnObject.GetComponent<PhysicalBehaviour>().burnIntensity = 3.5f;
            }
            yield return new WaitForSeconds(4);
        }
    }
}