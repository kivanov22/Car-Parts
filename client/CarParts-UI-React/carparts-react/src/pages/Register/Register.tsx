import React from 'react'
import "./Register.scss"

const Register = () => {
  return (
    <form className='register'>
      <h1>Register</h1>
      <label htmlFor="">Username</label>
      <input type="text" placeholder='enter username'/>
      <label htmlFor="">Password</label>
      <input type="text" placeholder='enter password'/>
      <label htmlFor="">Confirm Password</label>
      <input type="text" placeholder='enter password'/>
      <hr />
      <p>Already got an account, click here!</p>
    </form>
  )
}

export default Register