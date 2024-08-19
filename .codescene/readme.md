## Usage

This folder is the CodeScene global code health rule override for the FitNesse fixture in this account. 

## Rationale for suppressing warnings:

- Large Assertion blocks: we're testing functions that are intended to be used in a script and return booleans if they ran successfully.
- Primitive obsession / string heavy function arguments: the functions are called by FitNesse which expects and returns primitives.