//
// Copyright 2015 Google Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

// FirebaseDemo_ESP8266 is a sample that demo the different functions
// of the FirebaseArduino API.

#include <ESP8266WiFi.h>
#include <FirebaseArduino.h>

// Firebase bilgileri
#define FIREBASE_HOST "wificommunication-fe74c.firebaseio.com"
#define FIREBASE_AUTH "nhvKyN6uaGwRuOrV5vmzHAIbFBPyfnwvYTAtNG9H"
//Bağlanılan ağ bilgileri
#define WIFI_SSID "ArenPhone"
#define WIFI_PASSWORD "idrisblg1"

void setup() {
  Serial.begin(9600);

  // Wifiye bağlanılıyor
  WiFi.begin(WIFI_SSID, WIFI_PASSWORD);
  Serial.print("connecting");
  while (WiFi.status() != WL_CONNECTED) {
    Serial.print(".");
    delay(500);
  }
  Serial.println();
  Serial.print("connected: ");
  //Ağın local adresi yazılır.
  Serial.println(WiFi.localIP());
  //Firebase başlatıldı.
  Firebase.begin(FIREBASE_HOST, FIREBASE_AUTH);
}

int n = 0;

void loop() {  
  // update value
  Firebase.setFloat("number", n);
  // handle error
  if (Firebase.failed()) {
      Serial.print("setting /number failed:");
      Serial.println(Firebase.error());  
      return;
  }
  delay(100);
  if(n==100)
  {
    n=0;
  }
  else  
    n+=10;
  }
