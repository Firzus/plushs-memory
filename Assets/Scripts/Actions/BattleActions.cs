using System.Collections.Generic;
using UnityEngine;

public class BattleActions : MonoBehaviour
{
    BattleManager Instance;
    [SerializeField] GameObject mitePrefab;
    [SerializeField] GameObject coleoPrefab;
    [SerializeField] GameObject sourisPrefab;
    [SerializeField] GameObject moomooPrefab;

    private void Start()
    {
        Instance = BattleManager.Instance;
    }
    public void SetupChapter1()
    {
        Vector3 rotation = new Vector3(0, 180, 0);
        BattlePlacement wave = Instance.nextBattlePlacement;
        wave.ClearBattlePlacement();

        wave.AddEnemy(new Coord(2, 1), mitePrefab, rotation, new Coord(1, 1), true);
        wave.AddEnemy(new Coord(2, -1), mitePrefab, rotation, new Coord(1, 1), true);
        wave.AddMoomoo((new Coord(-2, 0), moomooPrefab));

        wave.nextWave = new BattlePlacement();
        wave = wave.nextWave;
        wave.AddEnemy(new Coord(2, 1), mitePrefab, rotation, new Coord(1, 1));
        wave.AddEnemy(new Coord(2, -1), mitePrefab, rotation, new Coord(1, 1));
        wave.AddMoomoo((new Coord(-2, 0), moomooPrefab));

        wave.nextWave = new BattlePlacement();
        wave = wave.nextWave;
        wave.AddEnemy(new Coord(2, 2), mitePrefab, rotation, new Coord(1, 1));
        wave.AddEnemy(new Coord(2, 0), mitePrefab, rotation, new Coord(1, 1));
        wave.AddEnemy(new Coord(2, -2), mitePrefab, rotation, new Coord(1, 1));
        wave.AddMoomoo((new Coord(-2, 0), moomooPrefab));

        Instance.originalPlacement = Instance.nextBattlePlacement;
    }
    public void SetupChapter2()
    {
        Vector3 rotation = new Vector3(0, 180, 0);
        BattlePlacement wave = Instance.nextBattlePlacement;
        wave.ClearBattlePlacement();
        wave.AddEnemy(new Coord(2, 2), mitePrefab, rotation, new Coord(1, 1));
        wave.AddEnemy(new Coord(2, 0), coleoPrefab, rotation, new Coord(1, 1));
        wave.AddEnemy(new Coord(2, -2), mitePrefab, rotation, new Coord(1, 1));
        wave.AddMoomoo((new Coord(-2, 0), moomooPrefab));


        wave.nextWave = new BattlePlacement();
        wave = wave.nextWave;
        wave.AddEnemy(new Coord(2, 2), mitePrefab, rotation, new Coord(1, 1));
        wave.AddEnemy(new Coord(2, 1), coleoPrefab, rotation, new Coord(1, 1));
        wave.AddEnemy(new Coord(2, -1), coleoPrefab, rotation, new Coord(1, 1));
        wave.AddEnemy(new Coord(2, -2), mitePrefab, rotation, new Coord(1, 1));
        wave.AddMoomoo((new Coord(-2, 0), moomooPrefab));

        Instance.originalPlacement = Instance.nextBattlePlacement;
    }
    public void SetupChapter3()
    {
        Vector3 rotation = new Vector3(0, 180, 0);
        BattlePlacement wave = Instance.nextBattlePlacement;
        wave.ClearBattlePlacement();
        wave.AddEnemy(new Coord(1, 2), mitePrefab, rotation, new Coord(1, 1));
        wave.AddEnemy(new Coord(1, 0), sourisPrefab, rotation, new Coord(2, 2), true);
        wave.AddEnemy(new Coord(1, -1), mitePrefab, rotation, new Coord(1, 1));
        wave.AddMoomoo((new Coord(-2, 0), moomooPrefab));

        Instance.originalPlacement = Instance.nextBattlePlacement;
    }
}