import React from "react";
import ProfileNavbar from "./ProfileNavbar.js";
import ProfileCard from "./ProfileCard.js";
import axios from "axios";

const ProfileDashboard = (props) => {
  return (
    <>
      <ProfileNavbar />
      <div className="flex">
        <ProfileCard />
      </div>
      <div className="flex">
        <ProfileCard />
      </div>
    </>
  );
};

export default ProfileDashboard;
