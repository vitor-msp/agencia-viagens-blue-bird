/********************* Formatação máscara data nascimento *********************/
const formatDtNasc = () => {
    const dtNasc = document.getElementById('dtNasc').innerHTML.trim();
    if (dtNasc) {
        document.getElementById('dtNasc').innerHTML = dtNasc.substring(0,10);
        return;
    }
    const hiddenDtNasc = document.getElementById('hiddenDtNasc').value.trim();
    if (hiddenDtNasc) {
        const day = hiddenDtNasc.substring(0, 2);
        const month = hiddenDtNasc.substring(3, 5);
        const year = hiddenDtNasc.substring(6, 10);
        document.getElementById('dtNasc').value = `${year}-${month}-${day}`;
    }
}
window.addEventListener('load', formatDtNasc);
/********************* Formatação máscara cpf *********************/
$(document).ready(function () {
    $("#cpf").inputmask("mask", { "mask": "999.999.999-99" }, { reverse: true });
});