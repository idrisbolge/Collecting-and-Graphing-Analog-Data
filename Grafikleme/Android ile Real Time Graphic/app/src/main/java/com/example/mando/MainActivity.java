package com.example.mando;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;
import com.jjoe64.graphview.GraphView;
import com.jjoe64.graphview.Viewport;
import com.jjoe64.graphview.series.DataPoint;
import com.jjoe64.graphview.series.LineGraphSeries;
import java.util.LinkedList;
import java.util.Queue;

public class MainActivity extends AppCompatActivity {

    GraphView graph;
    Button btn;
    FirebaseDatabase database;
    DatabaseReference reference;
    Queue kuyruk = new LinkedList();
    TextView text;
    private LineGraphSeries<DataPoint> series;
    private int lastX = 0;
    int deger = 0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        btn = findViewById(R.id.btn);
        graph  = (GraphView)findViewById(R.id.mygraph);
        text = findViewById(R.id.text);
        series = new LineGraphSeries<DataPoint>();
        graph.addSeries(series);
        Viewport viewport=graph.getViewport();
//        viewport.setYAxisBoundsManual(true);
          viewport.setScrollable(true);


        database = FirebaseDatabase.getInstance();
        reference = database.getReference("ABC123");

        setListeners();


    }

    private void setListeners() {
        btn.setOnClickListener(new View.OnClickListener() {

            @Override
            public void onClick(View v) {
                Addpoint pt = new Addpoint();
                pt.start();
                reference = FirebaseDatabase.getInstance().getReference().child("ABC123");
                reference.addValueEventListener(new ValueEventListener() {
                    @Override
                    public void onDataChange(@NonNull DataSnapshot dataSnapshot) {
                        int index = Integer.valueOf(dataSnapshot.child("indexNo").getValue().toString());
                        float value = Float.parseFloat(dataSnapshot.child("Value").getValue().toString());
                        if (index!=deger){
                            kuyruk.add(value);
                            Log.e("idris", String.valueOf(value) );
                            deger = index ;
                        }

                    }
                    @Override
                    public void onCancelled(@NonNull DatabaseError databaseError) {
                    }}); }}); }

    public class Addpoint extends Thread {
        float value;
        public void run() {
            while (true) {
                if (!kuyruk.isEmpty()) {
                    value = (float) kuyruk.poll();
                    series.appendData(new DataPoint(lastX++, value),true,80);
                    graph.addSeries(series);
                }
            }
        }



    }


}
