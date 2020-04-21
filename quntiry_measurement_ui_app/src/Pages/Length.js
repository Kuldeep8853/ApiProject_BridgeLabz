import React from 'react'
import { InchToFeet } from '../Controller/Services';

export class Length extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            length: parseInt(''),
            inputParameter: 'Inch',
            outputParameter:'Feet',
        };
    }

    handleLengthChang = (event) => {
        this.setState({ length: event.target.value });
        console.log(this.state.length);
    }

    componentDidUpdate(length){
        InchToFeet(length)
        .then(response => {
            console.log("Converter response====>", response);

        }).catch((err) => {
            console.log("error while converting Inch to feet----------", err);
        });
        }

    render() {
        return (
            <>
                <div>
                    <input type="number" className="input" onChange={this.handleLengthChang} />
                    <select className="SelectItems" >
                        <option value="Feet">Feet</option>
                        <option value="Inch"> Inch</option>
                    </select>
                </div>
                <div className="equal">=</div>
                <div>
                    <input type="number" className="input" onChange={this.handleLengthChang} />
                    <select className="SelectItems" >
                        <option value="Feet">Feet</option>
                        <option value="Inch"> Inch</option>
                    </select>
                </div>
            </>
        )
    };
}
export default Length;