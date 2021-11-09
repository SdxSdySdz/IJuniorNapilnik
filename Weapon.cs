class Weapon
{
    private int _damage;
    private int _bulletsCount;

    public void Fire(Player player)
    {
        player.TakeDamage(_damage);
        _bulletsCount -= 1;
    }
}

class Player
{
    private int _health;

    public void TakeDamage(int damage)
    {
        if (damage < 0)
            throw new ArgumentOutOfRangeException();

        _health -= damage;
    }
}

class Bot
{
    public Weapon Weapon;

    public void OnSeePlayer(Player player)
    {
        Weapon.Fire(player);
    }
}