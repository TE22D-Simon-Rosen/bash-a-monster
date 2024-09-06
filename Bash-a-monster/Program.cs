Entity player = new();
Entity enemy = new();
Random random = new();

player.hp = 100;
enemy.hp = 100;

player.name = "player";
enemy.name = "enemy";

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