import React from 'react'
import './LoadingSpinner.scss';
import tire from '../../other/tire.gif'

const LoadingSpinner = () => {
  return (
    <div className='lodingSpinner'>
        <img src={tire} alt="loading" />
    </div>
  )
}

export default LoadingSpinner