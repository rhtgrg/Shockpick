using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DriverPinManager : MonoBehaviour {
	public List<Driver> availableDrivers;
	public List<Driver> stuckDrivers;
	Driver currentPin;

	void Start () {
		foreach (Driver driver in availableDrivers) {
			driver.driverPinManager = this;
		}
		SelectCurrentPin();
	}

	public void StickPin (Driver pin) {
		// Sanity check
		if(pin != currentPin) {
			Debug.LogError("Pin that wasn't current tried to get stuck!");
			return;
		}

		pin.current = false;

		availableDrivers.Remove(pin);
		stuckDrivers.Add(pin);

		SelectCurrentPin();
	}

	public void UnstickPin (Driver pin) {
		availableDrivers.Add(pin);
		stuckDrivers.Remove(pin);
	}

	void SelectCurrentPin () {
		if(availableDrivers.Count > 0) {
			// Select a random pin to be current
			currentPin = availableDrivers[Random.Range(0, availableDrivers.Count)];
			currentPin.current = true;
		}
	}
}
