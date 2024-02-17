let basicUrl = 'https://localhost:7026/api/Pizza/';
let pizzatbody = document.getElementById("pizzatbody");

function getAllPizzas(params) {
    fetch(`${basicUrl}getAll`)
        .then(res => res.json())
        .then(data => {
            console.log(data);
            fillPizzaList(data);
        })
        .catch(err => {
            console.log(err);
            alert(err);
        });
}

function fillPizzaList(pizzaList) {

    let pizzatbody = document.getElementById("pizzatbody");
    pizzaList.forEach(pizza => {
        var tr = `<tr>
        <td>${pizza.name}</td>
        <td>${pizza.price}</td>
        </tr>`
        pizzatbody.innerHTML += tr;
    });

}

function getById() {
    let id = document.getElementById("getId").value;
    fetch(`${basicUrl}${id}`)
        .then(res => res.json())
        .then(pizza => {
            console.log(pizza);
            var tr = `<tr>
        <td>${pizza.name}</td>
        <td>${pizza.price}</td>
        </tr>`
            pizzatbody.innerHTML = tr;
            console.log(pizza);
        })
        .catch((err) => {
            console.log("in eror!!!!");
            console.log(err);
        });

}

function postPizza() {
    let pizza = {
        Id: 0,
        Price: document.getElementById("pizzaPrice").value,
        IsGluten: document.getElementById("pizzIsGluten").checked,
        Name: document.getElementById("pizzaName").value
    };

    let p = {
        id: 6,
        isGluten: true,
        name: "Angel",
        price: 20
    }
    let pi={
        "id": 2,
        "price": 58,
        "isGluten": true,
        "name": "Veggie"
      }
    let httpReqest = {
        method: "POST",
        body: "",
        redirect: "follow"
    }
    var raw="";
    var requestOptions = {
        method: 'POST',
        body: raw,
        redirect: 'follow'
    };

    fetch(`${basicUrl}${p}`, requestOptions)
        .then(res => {
            res.text();
            console.log(res);
        })
        .catch(err => console.log(err + "errrrrrrrrr"));
}
