var container = document.getElementById('container');

var request = new XMLHttpRequest();

request.open('GET', 'https://ghibliapi.herokuapp.com/people', true);

request.onload = function() {
    var data = JSON.parse(this.response);
    if(request.status >= 200 && request.status < 400){
        data.forEach(person => {
            const card = document.createElement('div');
            card.setAttribute('class', 'card');

            const h1 = document.createElement('h1');
            h1.textContent = person.name;

            const p = document.createElement('p');
            p.textContent = person.age;
            
            container.appendChild(card);

            card.appendChild(h1);
            card.appendChild(p);
        });
    } else {
        console.log('error');
    }
}

request.send();

