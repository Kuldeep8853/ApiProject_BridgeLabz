import React from 'react'
import { KgToGm } from '../Controller/Services';

export class Weight extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            weight: parseInt(''),
            inputParameter: 'Kilogram',
            outputParameter:'Gram',
        };
    }
    handleWeightChang = (event) => {
        const weight = event.target.value;
        this.setState({
            weight: weight
        });
        console.log("length", this.state.weight);
    }

    componentDidUpdate(weight){
        KgToGm(weight)
        .then(response => {
            console.log("Converter response====>", response);

        }).catch((err) => {
            console.log("error while converting Kg to Gm----------", err);
        });
    }

    render() {
        return (
            <>
                <div>
                    <input type="number" className="input" onChange={this.handleWeightChang} />
                    <select className="SelectItems">
                        <option value="Kilogram"> Kilogram</option>
                        <option value="Gram"> Gram</option>
                    </select>
                </div>
                <div className="equal">=</div>
                <div>
                    <input type="number" className="input" onChange={this.handleWeightChang} />
                    <select className="SelectItems">
                        <option value="Kilogram"> Kilogram</option>
                        <option value="Gram"> Gram</option>
                    </select>
                </div>
            </>
        )
    }
}
export default Weight;
