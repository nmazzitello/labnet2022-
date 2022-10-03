const contenedor= document.getElementById("contenedor");
const formulario= document.getElementById("formulario");
const bigbox= document.querySelector(".bigBox")
let nombre= document.getElementById("nombre");
let apellido= document.getElementById("apellido");
let edad= document.querySelector("#edad");
let sexo= document.getElementsByName('sexo');

let empresa= document.querySelector("#empresa");

const objetoNuevo={
    nombre: "",
    apellido: "",
    edad:"",
    genero:"",
    empresa:""
}

formulario.addEventListener("submit", CargarDatos);

function CargarDatos(e){
    e.preventDefault();
    
    if(Validar()){
        
        let sexoo;
        sexo.forEach(radio => {
            if(radio.checked)
            {
               sexoo=radio.value;
            }
        });

        objetoNuevo.apellido= apellido.value;
        objetoNuevo.nombre=nombre.value;
        objetoNuevo.edad=edad.value;
        objetoNuevo.genero=sexoo;
        objetoNuevo.empresa=empresa.value;

        alert("Cargado correctamente los datos de "+objetoNuevo.apellido+", "+objetoNuevo.nombre);
    }

    formulario.reset();
}

function  Validar(){
    if(nombre.value==="" || apellido.value===""){
        MostrarError("Los campos nombre y apellido son requeridos");
        return false;
    }else{
        return true;
    }
}

function MostrarError(mensaje){
    const mensajeErrorExiste= document.querySelector(".error");

    if(!mensajeErrorExiste){
        const mensajeError= document.createElement("p");

        mensajeError.textContent=mensaje;
        mensajeError.classList.add("error");
    
        formulario.insertBefore(mensajeError, bigbox);

        setTimeout(() => {
            mensajeError.remove();
        }, 3000);
    }
}

function LimpiarFormulario(){

}