const axios = require('axios');

export async function InchToFeet(length) {
    try {
        return axios.get(`https://localhost:5001/api/Length/api/InchToFeet?inch=${length}`)
            .then(response => {
                return response
            })
    }
    catch (error) {
        console.log("error while converting Inch to feet" + error)
        return Promise.resolve(false)
    }
}

export async function FeetToInch(length) {
   
    try {
        return axios.get(`https://localhost:5001/api/Length/api/FeetToInch?feet=${length}`)
            .then(response => {
                return response
            })
    }
    catch (error) {
        console.log("error while converting feet to Inch" + error)
        return Promise.resolve(false)
    }
}

export async function KgToGm(weight) {
    try {
        return axios.get(`https://localhost:5001/api/Weight/api/KgToGm?kg=${weight}`)
            .then(response => {
                return response
            })
    }
    catch (error) {
        console.log("error while converting Kg to Gm" + error)
        return Promise.resolve(false)
    }
}

export async function GmToKg(weight) {
    try {
        return axios.get(`https://localhost:5001/api/Weight/api/GmToKg?gm=${weight}`)
            .then(response => {
                return response
            })
    }
    catch (error) {
        console.log("error while converting Gm to Kg" + error)
        return Promise.resolve(false)
    }
}

export async function CelciusToFahrenheit(temprature) {
    try {
        return axios.get(`https://localhost:5001/api/Temp/api/CelciusToFahrenheit?celcious=${temprature}`)
            .then(response => {
                return response
            })
    }
    catch (error) {
        console.log("error while converting Celcius To Fahrenheit" + error)
        return Promise.resolve(false)
    }
}

export async function FahrenheitToCelcius(temprature) {
    try {
        return axios.get(`https://localhost:5001/api/Temp/api/FahrenheitToCelcius?fahrenheit=${temprature}`)
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