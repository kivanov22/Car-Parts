import React from 'react'
import "./Login.scss"

const Login = () => {
  return (
    <form className='login'>
      <h1>Login</h1>
      <label htmlFor="">Username</label>
      <input type="text" placeholder='enter username'/>
      <label htmlFor="">Password</label>
      <input type="text" placeholder='enter password'/>
      <hr />
      <p>Not registered, click here!</p>
    </form>
  )
}

export default Login