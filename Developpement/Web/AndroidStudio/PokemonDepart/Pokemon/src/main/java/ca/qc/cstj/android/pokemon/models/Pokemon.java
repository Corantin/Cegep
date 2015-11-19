package ca.qc.cstj.android.pokemon.models;

// Fonctionne seulement après l'ajout de la dependencies.
import com.google.gson.JsonArray;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;

import java.util.ArrayList;

/**
 * Created by 1345145 on 2015-10-23.
 */
public class Pokemon {
    private String pokedexNo;
    private String nom;

    public Pokemon(JsonObject object) {
        this.pokedexNo = object.getAsJsonPrimitive("pokedexNo").getAsString();
        this.nom = object.getAsJsonPrimitive("name").getAsString();
    }

    public static ArrayList<Pokemon> createFromJson(JsonArray jsonArray) {
        ArrayList<Pokemon> pokemons = new ArrayList<>();

        for(JsonElement element : jsonArray) {
            pokemons.add(new Pokemon(element.getAsJsonObject()));
        }

        return pokemons;
    }

    public String getPokedexNo() {
        return pokedexNo;
    }

    public void setPokedexNo(String pokedexNo) {
        this.pokedexNo = pokedexNo;
    }

    public String getNom() {
        return nom;
    }

    public void setNom(String nom) {
        this.nom = nom;
    }
}
