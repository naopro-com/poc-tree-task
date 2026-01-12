// Fonction pour télécharger un fichier
window.downloadFile = function (filename, content) {
    const element = document.createElement('a');
    const blob = new Blob([atob(content)], { type: 'application/json' });
    element.href = URL.createObjectURL(blob);
    element.download = filename;
    document.body.appendChild(element);
    element.click();
    document.body.removeChild(element);
    URL.revokeObjectURL(element.href);
};

// Fonction pour obtenir toutes les clés du localStorage
window.getAllLocalStorageKeys = function () {
    const keys = [];
    for (let i = 0; i < localStorage.length; i++) {
        keys.push(localStorage.key(i));
    }
    return JSON.stringify(keys);
};