package ca.qc.cstj.android.pokemon.adapters;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import com.koushikdutta.ion.Ion;

import java.net.URI;
import java.util.ArrayList;

import ca.qc.cstj.android.pokemon.R;
import ca.qc.cstj.android.pokemon.Services;
import ca.qc.cstj.android.pokemon.models.Pokemon;

/**
 * Created by 1334725 on 2015-10-23.
 */
public class PokemonAdapter extends ArrayAdapter<Pokemon> {

    private static class ViewHolder {
        ImageView imgPokemon;
        TextView lblNomPokemon;
    }

    public PokemonAdapter(Context context, ArrayList<Pokemon> pokemons){
        super(context, 0, pokemons);
    }


    @Override
    public View getView(int position, View convertView, ViewGroup parent) {

        Pokemon pokemon = getItem(position);
        ViewHolder viewHolder;

        if (convertView == null){
            viewHolder = new ViewHolder();
            LayoutInflater inflater = LayoutInflater.from(getContext());
            convertView = inflater.inflate(R.layout.listitem_pokemon,parent,false);
            viewHolder.imgPokemon = (ImageView)convertView.findViewById(R.id.imgPokemon);
            viewHolder.lblNomPokemon = (TextView)convertView.findViewById(R.id.lblNomPokemon);
            convertView.setTag(viewHolder);
        } else {
            viewHolder = (ViewHolder)convertView.getTag();
        }

        Ion.with(getContext())
                .load(new StringBuilder().append(Services.POKEMON_IMG).append(pokemon.getPokedexNo()).append(".png").toString())
                .withBitmap()
                .placeholder(R.drawable.spinner)
                .error(R.drawable.error)
                .intoImageView(viewHolder.imgPokemon);


        viewHolder.lblNomPokemon.setText(pokemon.getNom());



        return  convertView;

    }
}
