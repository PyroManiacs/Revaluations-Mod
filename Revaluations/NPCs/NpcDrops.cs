using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace Revaluations.NPCs
{
    public class NpcDrops : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.KingSlime)   //this is where you choose the npc you want
            {
                if (Main.rand.Next(4) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CrystalSmasher"), 1); //this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
                    }
                }
            }
            if (npc.type == NPCID.Mummy)   //this is where you choose the npc you want
            {
                if (Main.rand.Next(3) == 0) //this is the item rarity, so 6 is 1 in 7 chance that the npc will drop the item.
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CursedDust"), 5); //this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
                    }
                }
            }
            if (npc.type == NPCID.Antlion)   //this is where you choose the npc you want
            {
                if (Main.rand.Next(3) == 0) //this is the item rarity, so 6 is 1 in 7 chance that the npc will drop the item.
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CursedDust"), 5); //this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
                    }
                }
            }
            if (npc.type == NPCID.Vulture)   //this is where you choose the npc you want
            {
                if (Main.rand.Next(3) == 0) //this is the item rarity, so 6 is 1 in 7 chance that the npc will drop the item.
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CursedDust"), 5); //this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
                    }
                }
            }
            if (npc.type == NPCID.FlyingAntlion)   //this is where you choose the npc you want
            {
                if (Main.rand.Next(3) == 0) //this is the item rarity, so 6 is 1 in 7 chance that the npc will drop the item.
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CursedDust"), 4); //this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
                    }
                }
            }
            if (npc.type == NPCID.WalkingAntlion)   //this is where you choose the npc you want
            {
                if (Main.rand.Next(3) == 0) //this is the item rarity, so 6 is 1 in 7 chance that the npc will drop the item.
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CursedDust"), 5); //this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
                    }
                }
            }
            if (npc.type == NPCID.SandSlime)   //this is where you choose the npc you want
            {
                if (Main.rand.Next(3) == 0) //this is the item rarity, so 3 is 1 in 4 chance that the npc will drop the item.
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CursedDust"), 5); //this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
                    }
                }
            }
            if (npc.type == mod.NPCType("PartyZombie"))//this is how you add your custom npc
            {
                if (Main.rand.Next(4) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("WatertiteOre"), 8); //this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
                    }
                }
            }
        }
    }
}