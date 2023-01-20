using MarkupAttributes;
using PokemonEssentials.Interface.PokeBattle;
using PokemonUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Trainer", menuName = "Pokemon Unity/Trainer")]
public class TrainerSO : ScriptableObject {
    [SerializeField] string trainerName = "Trainer";
    public TrainerClassSO Class;
    // TODO: figure out what a PokemonInitialiser is and how it should work with PokemonSO
    public PokemonInitialiser[] trainerParty = new PokemonInitialiser[1];
    public PokemonSO[] Party;
    //
    public List<Dialogue> Dialogue;

    public string FullName { get => Class.ClassName + " " + trainerName; }

    public string Name { get => trainerName; }
    
    public new string name { get => trainerName; }

    public int GetPrizeMoney() => Class.BasePrizeMoney * Party[Party.Length-1].Level;

    public void HealParty() {
        foreach (IPokemon pokemon in Party)
            pokemon.Heal();
    }
}