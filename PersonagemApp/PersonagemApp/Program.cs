using System;

namespace PersonagemApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem myCharacter = new Personagem();

            // Coletando os dados do personagem pelo usuário
            myCharacter.CollectCharacterData();

            // Escolhendo a habilidade especial
            myCharacter.ChooseSpecialSkill();

            // Ajuste para definir o nível inicial do personagem
            myCharacter.Level = 1;

            // Distribuição inicial dos pontos do personagem
            myCharacter.DistributePoints();

            // Coletando e validando a idade
            myCharacter.SetCharacterAge();

            // Exibindo informações do usuário
            myCharacter.DisplayInfo();

            // Adicionando itens ao inventário
            Console.WriteLine("Deseja adicionar itens ao inventário do seu personagem? (s/n)");
            string response = Console.ReadLine().ToLower();
            while (response == "s")
            {
                Console.Clear();

                Console.Write("Nome do item: ");
                string itemName = Console.ReadLine();

                Console.Write("Tipo do item (e.g., Arma, Armadura, Poção): ");
                string itemType = Console.ReadLine();

                Console.Write("Quantidade do item: ");
                int itemQuantity = int.Parse(Console.ReadLine());

                // Solicitando bônus dos itens
                Console.Write("Bônus de Ataque: ");
                int attackBonus = int.Parse(Console.ReadLine());

                Console.Write("Bônus Crítico: ");
                int criticalBonus = int.Parse(Console.ReadLine());

                Console.Write("Bônus de Vida: ");
                int healthBonus = int.Parse(Console.ReadLine());

                Console.Write("Bônus de Agilidade: ");
                int agilityBonus = int.Parse(Console.ReadLine());

                Console.Write("Bônus de Velocidade: ");
                int speedBonus = int.Parse(Console.ReadLine());

                Item newItem = new Item(itemName, itemType, itemQuantity, attackBonus, criticalBonus, healthBonus, agilityBonus, speedBonus);
                myCharacter.AddItemToInventory(newItem);

                Console.WriteLine("Item adicionado ao inventário.");
                myCharacter.DisplayInventory();

                Console.WriteLine("Deseja adicionar outro item? (s/n)");
                response = Console.ReadLine().ToLower();
            }

            // Exibindo informações finais do personagem
            myCharacter.DisplayInfo();

            while (true)
            {
                Console.WriteLine("Quer ganhar experiencia? s/n");
                response = Console.ReadLine().ToLower();
                if (response == "n")
                {
                    break;
                }

                Console.Write("Quanto de xp quer ganhar?");
                int experiencePoints = int.Parse(Console.ReadLine());
                myCharacter.GainExperience(experiencePoints);

                //exibindo informacoes atualizadas do personagem
                myCharacter.DisplayInfo();
            }

            Console.Clear();
            Console.WriteLine("Informacoes finais");
            myCharacter.DisplayInfo();
            Console.WriteLine("GG");
        }
    }
}