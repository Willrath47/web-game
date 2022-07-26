
window.addEventListener('DOMContentLoaded', event => {

    const sideNav = document.body.querySelector('#sideNav');
    if (sideNav) {
        new bootstrap.ScrollSpy(document.body, {
            target: '#sideNav',
            offset: 74,
        });
    };

    const navbarToggler = document.body.querySelector('.navbar-toggler');
    const responsiveNavItems = [].slice.call(
        document.querySelectorAll('#navbarResponsive .nav-link')
    );
    responsiveNavItems.map(function (responsiveNavItem) {
        responsiveNavItem.addEventListener('click', () => {
            if (window.getComputedStyle(navbarToggler).display !== 'none') {
                navbarToggler.click();
            }
        });
    });

});


document.getElementById("boton-jugar").onclick =  function (){
    location.href = "https://willrath47.itch.io/parabola-game";
}
document.getElementById("imagen-man").onclick =  function (){
    location.href = "https://willrath47.itch.io/parabola-game";
    
}

document.getElementById("boton-lista").onclick =  function (){
    location.href = "https://willrath47.github.io/todo/";
}

document.getElementById("imagen-lista").onclick =  function (){
    location.href = "https://willrath47.github.io/todo/";
    
}


document.getElementById("boton-restaurante").onclick =  function (){
    location.href = "https://willrath47.github.io/pagina-restaurante/";
}

document.getElementById("imagen-restaurante").onclick =  function (){
    location.href = "https://willrath47.github.io/pagina-restaurante/";
    
}

document.getElementById("imagen-React").onclick =  function (){
    location.href = "https://willrath47.github.io/react-counter/";
    
}

document.getElementById("boton-React").onclick =  function (){
    location.href = "https://willrath47.github.io/react-counter/";
    
}






