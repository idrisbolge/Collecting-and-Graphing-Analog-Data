
void setup() {
  Serial.begin(9600);
}

void loop() {
float in,out;
  for (in = 0; in < 6.283; in = in + 0.01){
  out = sin(in)*127.5+127.5;
  Serial.println(out);
  delay(100);
  }
}
