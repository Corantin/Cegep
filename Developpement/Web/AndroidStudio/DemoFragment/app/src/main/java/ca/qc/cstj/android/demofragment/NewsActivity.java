package ca.qc.cstj.android.demofragment;

import android.app.Activity;
import android.app.FragmentTransaction;
import android.content.res.Configuration;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;


public class NewsActivity extends Activity implements TitresFragment.OnFragmentInteractionListener{

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.news_activity);

        // Tester si nous sommes dans le mode portrait.
        if(findViewById(R.id.fragment_container) != null) {
            if(savedInstanceState != null) {
                return;
            }

            // Afficher le fragment des titres.
            TitresFragment titresFragment = TitresFragment.newInstance();
            titresFragment.setArguments(getIntent().getExtras());
            getFragmentManager().beginTransaction().add(R.id.fragment_container, titresFragment).commit();
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

        // Un article a été selectionné



        if (getResources().getConfiguration().orientation != Configuration.ORIENTATION_LANDSCAPE){
            // Mode Paysage
            ArticleFragment articleFragment = (ArticleFragment) getFragmentManager().findFragmentById(R.id.article_fragment);
            articleFragment.updateArticleView(position);
        } else if(getResources().getConfiguration().orientation != Configuration.ORIENTATION_PORTRAIT){
            // Mode Portrait
            ArticleFragment newArticleFragment = ArticleFragment.newInstance(position);
            FragmentTransaction transaction = getFragmentManager().beginTransaction();

            transaction.replace(R.id.fragment_container, newArticleFragment);
            transaction.addToBackStack(null);

            transaction.commit();
        }
    }
}
