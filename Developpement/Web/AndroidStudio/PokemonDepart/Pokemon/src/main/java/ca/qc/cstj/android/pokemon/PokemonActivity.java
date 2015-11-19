package ca.qc.cstj.android.pokemon;

import android.app.Activity;
import android.app.FragmentTransaction;
import android.content.res.Configuration;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;


public class PokemonActivity extends Activity implements PokemonListFragment.OnFragmentInteractionListener {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_pokemon);

        //Tester que l'activité utilise la version avec le fragment_container (Téléphone - Layout)
        if(findViewById(R.id.fragment_container) != null) {
            //Test si nous revenons ici avec un ancienne état, l'application vient d'être redémarré
            //On fait rien
            if(savedInstanceState != null) {
                return;
            }

            //Nous allons ajouter le premier fragement HeadlinesFragment

            PokemonListFragment titreFragment = PokemonListFragment.newInstance();
            titreFragment.setArguments(getIntent().getExtras());
            getFragmentManager().beginTransaction().add(R.id.fragment_container, titreFragment).commit();
        }
    }


    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_news, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }

    @Override
    public void onFragmentInteraction(int position) {

        DetailFragment detailFragment = (DetailFragment) getFragmentManager().findFragmentById(R.id.detail_fragment);

        if(getResources().getConfiguration().orientation == Configuration.ORIENTATION_LANDSCAPE) {
            detailFragment.updateDetailView(position);
        } else if(getResources().getConfiguration().orientation == Configuration.ORIENTATION_PORTRAIT) {
            DetailFragment newDetailFragment = DetailFragment.newInstance(position);
            FragmentTransaction transaction = getFragmentManager().beginTransaction();

            transaction.replace(R.id.fragment_container, newDetailFragment);
            transaction.addToBackStack(null);

            transaction.commit();
        }


    }
}
