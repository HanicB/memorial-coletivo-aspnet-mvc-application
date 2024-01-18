
        // Função para definir a cor e armazenar no cookie
    function changeColor(color) {
        document.body.className = color + "-color";
    document.cookie = "chosenColor=" + color + "; path=/"; // Armazena a cor escolhida em um cookie
        }

    // Função para obter a cor armazenada no cookie
    function getChosenColor() {
            var match = document.cookie.match(new RegExp('(^| )chosenColor=([^;]+)'));
    return match ? match[2] : null;
        }

    // Define a cor armazenada, se existir
    var storedColor = getChosenColor();
    if (storedColor) {
        changeColor(storedColor);
        }
