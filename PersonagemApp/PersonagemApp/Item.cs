namespace PersonagemApp
{
    public class Item
    {
        public string Name { get; set; }
        public string Type { get; set; } // Tipo do item (e.g., Arma, Armadura, Poção)
        public int Quantity { get; set; } = 1;

        // Propriedades para bônus adicionais
        public int AttackBonus { get; set; }
        public int CriticalBonus { get; set; }
        public int HealthBonus { get; set; }
        public int AgilityBonus { get; set; }
        public int SpeedBonus { get; set; }

        public Item(string name, string type, int quantity = 1, int attackBonus = 0, int criticalBonus = 0, int healthBonus = 0, int agilityBonus = 0, int speedBonus = 0)
        {
            Name = name;
            Type = type;
            Quantity = quantity;
            AttackBonus = attackBonus;
            CriticalBonus = criticalBonus;
            HealthBonus = healthBonus;
            AgilityBonus = agilityBonus;
            SpeedBonus = speedBonus;
        }

        public override string ToString()
        {
            return $"{Name} (Tipo: {Type}, Quantidade: {Quantity}, Ataque: {AttackBonus}, Crítico: {CriticalBonus}, Vida: {HealthBonus}, Agilidade: {AgilityBonus}, Velocidade: {SpeedBonus})";
        }
    }
}
