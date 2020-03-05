var valid = document.getElementById("ok");
valid.addEventListener("click",val);

function val(event){

    var adherent = document.getElementById("adherent");
    var region = document.getElementById("region");
    var departement = document.getElementById("departement");
    var pays = document.getElementById("pays");
    var a = document.getElementById("are");
    var verif = document.getElementById("verif");

    var blockAd = /[a-zA-Z]/;
    var blockReg = /[a-zA-Z]/;
    var blockDep = /[0-9a-zA-Z]/;
    var blockPays = /[a-zA-Z]/; // on prendra 5 nombres entier */
    var area = /^[0-9a-zA-ZàèìòùÀÈÌÒÙáéíóúýÁÉÍÓÚÝâêîôûÂÊÎÔÛãñõÃÑÕäëïöüÿÄËÏÖÜŸçÇßØøÅåÆæœÉ]+(?:(?:\'| |\-|\?|\(|\)|\.|\,|\;|\:)?[a-zA-ZàèìòùÀÈÌÒÙáéíóúýÁÉÍÓÚÝâêîôûÂÊÎÔÛãñõÃÑÕäëïöüÿÄËÏÖÜŸçÇßØøÅåÆæœÉ]+)*$/;

    var missAdherent = document.getElementById("missAdherent");
    var missRegion = document.getElementById("missRegion");
    var missDepartement = document.getElementById("missDepartement");
    var missPays = document.getElementById("missPays");
    var missARE = document.getElementById("missARE");
    var missVerif = document.getElementById("missVerif");

    if(!blockAd.test(adherent.value)){
        event.preventDefault();
        missAdherent.innerHTML = "Veuillez saisir votre Nom";
        missAdherent.style.color = "red";
        missAdherent.style.display = "block";
    }else{
        missAdherent.innerHTML= "valide";
        missAdherent.style.color = "green";
    }
    if(!blockReg.test(region.value)){
        event.preventDefault();
        missRegion.innerHTML = "Veuillez saisir votre Prenom";
        missRegion.style.color = "red";
        missRegion.style.display = "block";
    }else{
        missRegion.innerHTML= "valide";
        missRegion.style.color = "green";

    }
    if(!blockDep.test(departement.value)){
        event.preventDefault();
        missDepartement.innerHTML = "Veuillez saisir un département";
        missDepartement.style.color = "red";
        missDepartement.style.display = "block";
    }else{
        missDepartement.innerHTML= "valide";
        missDepartement.style.color = "green";
    }
    if(!blockPays.test(pays.value)){
        event.preventDefault();
        missPays.innerHTML = "Veuillez saisir la date de séjour";
        missPays.style.color = "red";
        missPays.style.display = "block";
    }else{
        missPays.innerHTML= "valide";
        missPays.style.color = "green";
    }
    if(!area.test(a.value)){
        event.preventDefault();
        missARE.innerHTML = "Caractère autorisé : '|espace|-|?|()|.|,|;|";
        missARE.style.color = "red";
        missARE.style.display = "block";
    }else{
        missARE.innerHTML= "valide";
        missARE.style.color = "green";
    }
    if (verif.validity.valueMissing)
    {
        event.preventDefault()
        missVerif.textContent = 'Veuillez accepter les conditions';
        missVerif.style.color = 'red';
        missVerif.style.display = "block";
    }
    else
    {
        missVerif.textContent = 'valide';
        missVerif.style.color = 'green';
    }
    var entrer = document.getElementById("oki");
    entrer.addEventListener("click",val);

    var adherent = document.getElementById("adherent");
    var region = document.getElementById("region");
    var departement = document.getElementById("departement");
    var pays = document.getElementById("pays");


    var blockAd = /[a-zA-Z]/;
    var blockReg = /[a-zA-Z]/;
    var blockDep = /[0-9a-zA-Z]/;
    var blockPays = /[a-zA-Z]/; // on prendra 5 nombres entier */
    var area = /^[0-9a-zA-ZàèìòùÀÈÌÒÙáéíóúýÁÉÍÓÚÝâêîôûÂÊÎÔÛãñõÃÑÕäëïöüÿÄËÏÖÜŸçÇßØøÅåÆæœÉ]+(?:(?:\'| |\-|\?|\(|\)|\.|\,|\;|\:)?[a-zA-ZàèìòùÀÈÌÒÙáéíóúýÁÉÍÓÚÝâêîôûÂÊÎÔÛãñõÃÑÕäëïöüÿÄËÏÖÜŸçÇßØøÅåÆæœÉ]+)*$/;

    var missAdherent = document.getElementById("missAdherent");
    var missRegion = document.getElementById("missRegion");
    var missDepartement = document.getElementById("missDepartement");
    var missPays = document.getElementById("missPays");


    if(!blockAd.test(adherent.value)){
        event.preventDefault();
        missAdherent.innerHTML = "Veuillez saisir votre Nom";
        missAdherent.style.color = "red";
        missAdherent.style.display = "block";
    }else{
        missAdherent.innerHTML= "valide";
        missAdherent.style.color = "green";
    }
    if(!blockReg.test(region.value)){
        event.preventDefault();
        missRegion.innerHTML = "Veuillez saisir votre Prenom";
        missRegion.style.color = "red";
        missRegion.style.display = "block";
    }else{
        missRegion.innerHTML= "valide";
        missRegion.style.color = "green";

    }
    if(!blockDep.test(departement.value)){
        event.preventDefault();
        missDepartement.innerHTML = "Veuillez saisir un département";
        missDepartement.style.color = "red";
        missDepartement.style.display = "block";
    }else{
        missDepartement.innerHTML= "valide";
        missDepartement.style.color = "green";
    }
    if(!blockPays.test(pays.value)){
        event.preventDefault();
        missPays.innerHTML = "Veuillez saisir pays";
        missPays.style.color = "red";
        missPays.style.display = "block";
    }else{
        missPays.innerHTML= "valide";
        missPays.style.color = "green";
    }

}