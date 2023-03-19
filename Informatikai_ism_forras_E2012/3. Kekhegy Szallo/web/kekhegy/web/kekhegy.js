function keres() {
  var xhr = new XMLHttpRequest();
  xhr.withCredentials = true;

  xhr.addEventListener("readystatechange", function () {
    if (this.readyState === 4) {
      console.log(this.responseText);
      let a = JSON.parse(this.responseText);
      console.log(a.kerdezoSzoveg);
      document.getElementById("kerdezo-szoveg").innerText = a.kerdezoSzoveg;
      document.getElementById("admin-szoveg").innerText = a.adminSzoveg;
    }
  });

  xhr.open("GET", "/api/chat");

  xhr.send();
}

function kerdesBekuldese() {
  var data = JSON.stringify({
    uzenet: document.getElementById("felhasznalo-kerdes").value
  });
  
  var xhr = new XMLHttpRequest();
  xhr.withCredentials = true;
  
  xhr.addEventListener("readystatechange", function() {
    if(this.readyState === 4) {
      console.log(this.responseText);
      alert("Kérdését megkaptuk, munkatársunk hamarosan válaszol!");
      document.getElementById("felhasznalo-kerdes").value = "";
    }
  });
  
  xhr.open("POST", "/api/kerdes");
  xhr.setRequestHeader("Content-Type", "application/json");
  
  xhr.send(data);
}
