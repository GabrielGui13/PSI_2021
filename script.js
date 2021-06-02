const fs = require('fs')
const http = require('http')

const arquivo = __dirname + "/index.cshtml"


function lerDados() {
    return new Promise(resolve => {
        fs.readFile(arquivo, 'utf-8', (err, data) => {
            resolve(data)
        })
    })
}

lerDados()
    .then(conteudo => {
        http.createServer((req, res) => {
            res.write(conteudo)
            res.end()
        }).listen(2424)
    })