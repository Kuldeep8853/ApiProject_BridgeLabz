import React from 'react'
import { CelciusToFahrenheit, FahrenheitToCelcius } from '../Controller/Services';

export class Temprature extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            temprature: '',
             input:'',
             result:'',
        };
    }
    handleTempChang = (event) => {
        const temprature = event.target.value;
        this.setState({
            temprature: temprature
        });
        console.log("length", this.state.temprature);
    }

    handleOnOption=(event)=>{
        this.setState({ input: event.target.value });
        console.log(this.state.input);
    }

    componentDidUpdate(){
        if(this.state.input=== 'Celcious' && this.state.input!== 'Fahrenhite')
        CelciusToFahrenheit(this.state.temprature).then(response => {
            this.setState({result:response.data})
        }).catch((err) => {
            console.log("error while converting Celcius To Fahrenheit----------", err);
        });

        if(this.state.input!== 'Celcious' && this.state.input=== 'Fahrenhite')
        FahrenheitToCelcius(this.state.temprature).then(response => {
            this.setState({result:response.data})
        }).catch((err) => {
            console.log("error while converting Fahrenheit To Celcius----------", err);
        });
    }

    render() {
        return (
            <>
                <div>
                    <input type="number" className="input" onChange={this.handleTempChang} />
                    <select className="SelectItems" onClick={this.handleOnOption}>
                        <option value="Celcious">Celcious</option>
                        <option value="Fahrenhite">Fahrenhite</option>
                    </select>
                </div>
                <div className="equal">=</div>
                <div>
                    <input type="number" className="input" value={this.state.result}  onClick={this.onClick}/>
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