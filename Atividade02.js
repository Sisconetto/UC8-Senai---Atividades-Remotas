 let nomeEvento = "Digite o nome do seu evento";
    console.log(nomeEvento);
    let data = "22/08/2021";
    if (data == "21/08/2021") {
        console.log("O cadastro não pode ser efetuado, pois a data é inválida.");
    }
   let participantes = ["Alice Valey", "Bruno Bernardo", "Camilo Borges"];
   console.log("Lista de participantes.");

   let numeroDeParticipantes = participantes.length;
   console.log(nomeEvento);
   if (participantes.length < 100) {  
   console.log("Digite o nome do participante");
   
   console.log("Digite sua idade");
   let idade = 18;
   if (idade >=18) {
       console.log("Digite seu email");
   }
    else {
       console.log("Voce não possui idade suficiente para participar do evento");

    } 
}
   
        else {
        console.log("Limite de participante excedido!")
           
       }
      
      console.log("Estes serão nossos Palestrantes:")  

    let listaDePalestrante = ["Arthur Alma", "Joana Spirit", "Leon Java"];
    let quantidadeDePalestrante = listaDePalestrante.length;
    for (let indice=0; indice < quantidadeDePalestrante; indice++) {
        const PalestranteDoEvento = listaDePalestrante[indice];
        console.log(PalestranteDoEvento);
    }
