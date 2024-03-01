import React from "react";
import HomeNav from "./HomeNav";
import PhoneIcon from "../../assets/1527145993.png";
import logo from "../../assets/1709039328654.png";

const HomePage = () => {
  return (
    <>
      <HomeNav />
      <div className="grid-cols-2">
        <div className="bg-sky-300 flex">
          <img src={logo} width="350px" height="30px" alt="quiz-logo" />
          <img src={PhoneIcon} width="740px" height="800px" alt="phone-icon" />
        </div>
      </div>
    </>
  );
};

export default HomePage;
