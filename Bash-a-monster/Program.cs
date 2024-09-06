Entity player = new();
Entity enemy = new();
Random random = new();

player.hp = 100;
enemy.hp = 100;


enemy.name = "enemy";

Console.WriteLine("Write a name to start: ");
player.name = Console.ReadLine();

string[] names = ["jeff", "banan", "olof", "ölkorv"];
enemy.name = names[random.Next(0, names.Length + 1)];


void ShowStats(Entity player, Entity enemy){
    Console.WriteLine($"\n{player.name} - {player.hp} hp  |  {enemy.name} - {enemy.hp} hp");
    Console.ReadLine();
}


void Attack(Entity attacker, Entity target){
    int damage = random.Next(attacker.minAttack, attacker.maxAttack);
    Console.WriteLine($"\n{attacker} deals {damage} damage to {target}!");
    target.hp -= damage;
    Console.ReadLine();
}


while (player.hp > 0 || enemy.hp > 0){
    ShowStats(player, enemy);
    Attack(player, enemy);
    ShowStats(player, enemy);
    Attack(enemy, player);
}