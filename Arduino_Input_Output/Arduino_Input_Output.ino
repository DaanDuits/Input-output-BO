
int val = 0;
int val2 = 0;
void setup() {
  // put your setup code here, to run once:
 // pinMode(In, INPUT);
  Serial.begin(9600); 
}

void loop() {
  // put your main code here, to run repeatedly:
  val = analogRead(A5);
  val = val < 20 ? 0: val;
  val2 = analogRead(A4);
  val2 = val2 < 300 ? 0 : val2;
  Serial.println(/*String(val2) + " " +*/ String(val));
}
