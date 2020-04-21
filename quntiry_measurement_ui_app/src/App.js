import React from 'react';
import './App.css';
import { BrowserRouter, Route, Switch } from 'react-router-dom';
import Length from './Pages/Length';
import Temprature from './Pages/Temprature';
import Weight from './Pages/Weight';
import { QuantityRow } from './component/QuantityRow';

function App() {
  return (
    <div className="App">
      <div className="optionColor">
        <h1>Quantity Measurment</h1>
        <QuantityRow/>
        <BrowserRouter>
      <div>
        <Switch>
        <Route path='/' component={Length} exact />
        <Route path='/' component={Weight} exact />
        <Route path='/' component={Temprature} exact/>
        </Switch>
      </div>
    </BrowserRouter>
      </div>
    </div>
  );
}
export default App;
