#include <Servo.h>

Servo turnOn;
Servo turnOff;


int pos = 0;

void setup() {

  //initialises two servos 
  turnOn.attach(9); // Turn on Activates one servo which will be used to turn on the heat
  turnOff.attach(10);  // Turn off Activates one servo which will be used to turn off the heat
  
  // Start our connection
  Serial.begin(9600);
  pinMode(LED_BUILTIN, OUTPUT);
  digitalWrite(LED_BUILTIN, HIGH); // turn on Led while connecting
  
  // Show a fancy flash pattern once connected
  digitalWrite(LED_BUILTIN, LOW); 
  delay(150);
  digitalWrite(LED_BUILTIN,HIGH); 
  delay(150);
  digitalWrite(LED_BUILTIN,LOW); 
  delay(150);
  digitalWrite(LED_BUILTIN,HIGH); 
  delay(150);
  digitalWrite(LED_BUILTIN,LOW); 
  delay(150);
  
}

void loop() {
 // If windows forms returns "on" loop sweeps servo #1
 char command = Serial.read();
  if (command == "on") {
    for (pos = 0; pos <= 180; pos += 1) { // goes from 0 degrees to 180 degrees
    // in steps of 1 degree
      turnOn.write(pos);              // tell servo to go to position in variable 'pos'
      delay(15);                       // waits 15ms for the servo to reach the position
    }
    for (pos = 180; pos >= 0; pos -= 1) { // goes from 180 degrees to 0 degrees
      turnOn.write(pos);              // tell servo to go to position in variable 'pos'
      delay(15);                       // waits 15ms for the servo to reach the position
    }
   }
  
  // If windows forms returns "off" loop sweeps servo #2
  if (command == "off") {
    for (pos = 0; pos <= 180; pos += 1) { // goes from 0 degrees to 180 degrees
    // in steps of 1 degree
      turnOff.write(pos);              // tell servo to go to position in variable 'pos'
      delay(15);                       // waits 15ms for the servo to reach the position
    }
    for (pos = 180; pos >= 0; pos -= 1) { // goes from 180 degrees to 0 degrees
      turnOff.write(pos);              // tell servo to go to position in variable 'pos'
      delay(15);                       // waits 15ms for the servo to reach the position
    }
  }
}











