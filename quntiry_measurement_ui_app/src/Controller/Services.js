const axios = require('axios');

export async function InchToFeet(length) {
    var headers = {
        'accept': 'application/json'
    }
    try {
        return axios.get('https://localhost:5001/api/Length/api/InchToFeet?inch='+length, { headers: headers })
            .then(response => {
                console.log(response)
                return response
            })
    }
    catch (error) {
        console.log("error while converting Inch to feet" + error)
        return Promise.resolve(false)
    }
}

export async function FeetToInch(length) {
    var headers = {
        'accept': 'application/json'
    }
    try {
        return axios.get('https://localhost:5001/api/Length/api/FeetToInch?feet='+length, { headers: headers })
            .then(response => {
                console.log(response)
                return response
            })
    }
    catch (error) {
        console.log("error while converting feet to Inch" + error)
        return Promise.resolve(false)
    }
}

export async function KgToGm(weight) {
    var headers = {
        'accept': 'application/json'
    }
    try {
        return axios.get('https://localhost:5001/api/Weight/api/KgToGm?kg='+weight, { headers: headers })
            .then(response => {
                console.log(response)
                return response
            })
    }
    catch (error) {
        console.log("error while converting Kg to Gm" + error)
        return Promise.resolve(false)
    }
}

export async function GmToKg(weight) {
    var headers = {
        'accept': 'application/json'
    }
    try {
        return axios.get('https://localhost:5001/api/Weight/api/GmToKg?gm='+weight, { headers: headers })
            .then(response => {
                console.log(response)
                return response
            })
    }
    catch (error) {
        console.log("error while converting Gm to Kg" + error)
        return Promise.resolve(false)
    }
}

export async function CelciusToFahrenheit(temprature) {
    var headers = {
        'accept': 'application/json'
    }
    try {
        return axios.get('https://localhost:5001/api/Temp/api/CelciusToFahrenheit?celcious='+temprature, { headers: headers })
            .then(response => {
                console.log(response)
                return response
            })
    }
    catch (error) {
        console.log("error while converting Celcius To Fahrenheit" + error)
        return Promise.resolve(false)
    }
}

export async function FahrenheitToCelcius(temprature) {
    var headers = {
        'accept': 'application/json'
    }
    try {
        return axios.get('https://localhost:5001/api/Temp/api/FahrenheitToCelcius?fahrenheit='+temprature, { headers: headers })
            .then(response => {
                console.log(response)
                return response
            })
    }
    catch (error) {
        console.log("error while converting Fahrenheit To Celcius" + error)
        return Promise.resolve(false)
    }
}