import React, { Component } from 'react';
import './TrafficLight.css';
import { getDefault, getCircle } from '../services/LightService.js'

export class Layout extends Component {

  constructor(props) {
    super(props);
    this.state = {
      color: undefined
    }
  }

  changeColor = async (color, time) => {
    setTimeout(async () => {
      const circle = await getCircle(color)
      this.setState({ color: circle.color })
      this.changeColor(circle.color, circle.time);
    }, time * 1000);

  }

  init = async () => {
    const defult = await getDefault()
    this.setState({ color: defult.color })
    this.changeColor(defult.color, defult.time);
  }

  componentDidMount() {
    this.init();
  }

  render() {
    return (
      <div>
        <div className={"flex-container"}>
          <div className={(this.state.color === 0 || this.state.color === 1) ? 'Red' : 'TurnedOff'}></div>
          <div className={(this.state.color === 3 || this.state.color === 1) ? 'Yellow' : 'TurnedOff'}></div>
          <div className={this.state.color === 2 ? 'Green' : 'TurnedOff'}></div>
        </div>
      </div>
    );
  }
}


