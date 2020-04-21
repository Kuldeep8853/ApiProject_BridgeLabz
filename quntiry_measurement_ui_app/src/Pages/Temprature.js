import React from 'react'
import { CelciusToFahrenheit } from '../Controller/Services';

export class Temprature extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            temprature: '',
            inputParameter: 'Celcious',
            outputParameter:'Fahrenhite',
        };
    }
    handleTempChang = (event) => {
        const temprature = event.target.value;
        this.setState({
            temprature: temprature
        });
        console.log("length", this.state.temprature);
    }

    componentDidUpdate(temprature){
        CelciusToFahrenheit(temprature)
        .then(response => {
            console.log("Converter response====>", response);

        }).catch((err) => {
            console.log("error while converting Celcius To Fahrenheit----------", err);
        });
    }

    render() {
        return (
            <>
                <div>
                    <input type="number" className="input" onChange={this.handleTempChang} />
                    <select className="SelectItems">
                        <option value="Celcious">Celcious</option>
                        <option value="Fahrenhite">Fahrenhite</option>
                    </select>
                </div>
                <div className="equal">=</div>
                <div>
                    <input type="number" className="input" onChange={this.handleTempChang} />
                    <select className="SelectItems">
                        <option value="Celcious">Celcious</option>
                        <option value="Fahrenhite">Fahrenhite</option>
                    </select>
                </div>
            </>
        )
    }
}
export default Temprature;